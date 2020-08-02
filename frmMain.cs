using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3Validator
{
    public partial class frmMain : Form
    {
        List<FileInfo> brokenFiles;
        private int goodFiles, badFiles;

        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnValidator_Click(object sender, EventArgs e)
        {
            goodFiles = 0;
            badFiles = 0;
            txtResults.Text = string.Empty;
            brokenFiles = new List<FileInfo>();

            var files = new List<string>();
            files.AddRange(Directory.GetFiles(txtPath.Text, "*.mp3", SearchOption.AllDirectories));

            await processPaths(files);

            if (chkFix.Checked)
            {
                await fixFiles(brokenFiles);
            }
        }

        private async Task processPaths(IEnumerable<string> paths)
        {
            var buffer = new byte[5];
            foreach (var filePath in paths)
            {
                var info = new FileInfo(filePath);

                using (var reader = info.OpenRead())
                {
                    var len = await reader.ReadAsync(buffer, 0, 5);

                    if (!isMp3Header(buffer))
                    {
                        badFiles++;
                        brokenFiles.Add(info);
                        txtResults.Text += info.FullName + Environment.NewLine;
                    }
                    else
                    {
                        goodFiles++;
                    }
                    lblGoodFiles.Text = goodFiles.ToString();
                    lblBadFiles.Text = badFiles.ToString();
                }
            }
        }

        private bool isMp3Header(byte[] bytes)
        {           
            var isId3Header = bytes?[0] == 0x49 && bytes?[1] == 0x44 && bytes?[2] == 0x33;
            var isMp3Frame = bytes?[0] == 0xFF && bytes?[1] == 0xFb;
            
            return isId3Header || isMp3Frame; 
        }

        private string getFixedName(string name)
        {
            return name.Replace(".mp3", ".fixed.mp3");
        }
        private async Task fixFiles(List<FileInfo> files)
        {
            foreach (var file in files)
            {
                var fixedName = getFixedName(file.FullName);

                var args = $"-y -i \"{file.FullName}\" -acodec copy \"{fixedName}\"";

                using (var process = new Process())
                {
                    process.StartInfo.FileName = "c:\\windows\\ffmpeg.exe";
                    process.StartInfo.Arguments = args;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    Debug.WriteLine(output);

                    process.WaitForExit();
                    Debug.WriteLine("Fixed " + file.Name + ", " + process.ExitCode);
                }
            }

            foreach (var file in files)
            {
                var fixedFile = new FileInfo(getFixedName(file.FullName));
                if (fixedFile.Exists)
                {
                    file.Delete();
                    fixedFile.MoveTo(file.FullName);
                }
            }
        }
    }
}
