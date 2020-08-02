# mp3validator
Windows program to check all MP3 files in a directory to see if the files are damaged. Files that do not have either an ID3 header or MP3 header in the first few bytes of the file are considered damaged. These files can optionally be repaired by invoking ffmpeg which reprocesses the MP3s.

Repairing any invalid MP3s requires that ffmpeg.exe is located exactly at c:\windows\ffmpeg.exe. 

A lot of enhancements could be made. I just wrote this to fix all my MP3s which were crashing when playing on embedded devices like an automotive receiver or a Sony Walkman MP3 player.
