using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RenameSongsFiles
{
    public class FFmpegHandle
    {
        public void getVolume(ref VideoEntity video) 
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = VideoHelper.FFmpegPath + "ffmpeg",
                    Arguments = $"-i \"{video.fullPath}\" -filter:a \"volumedetect\" -map 0:a -f null /dev/nul",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }

            };


            process.Start();
            string output = process.StandardError.ReadToEnd();
            process.WaitForExit();


            Match meanMatch = Regex.Match(output, @"mean_volume: ([0-9.-]+) dB");
            if (meanMatch.Success)
            {
                video.audio.volume.meanVolume = meanMatch.Groups[1].Value;
            }

            Match maxMatch = Regex.Match(output, @"max_volume: ([0-9.-]+) dB");
            if (maxMatch.Success)
            {
                video.audio.volume.maxVolume = maxMatch.Groups[1].Value;
            }
        }

        public void normalizeVolume(VideoEntity video)
        {
            string outPutFile = $@"{VideoHelper.LocalTempUser}\{video.fileName}";
            string output = "";
            using (Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = VideoHelper.FFmpegPath + "ffmpeg",
                    Arguments = $"-i \"{video.fullPath}\" -map 0 -c:v copy -af \"loudnorm=I=-16:TP=-1.5:LRA=11\" \"{outPutFile}\"",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }

            })
            {
                process.Start();
                output = process.StandardError.ReadToEnd();
                process.WaitForExit();
            }

            if (File.Exists(outPutFile))
            {
                File.Copy(outPutFile, video.fullPath, overwrite: true);
                File.Delete(outPutFile);
            }

        }

    }

    #region examples
    /*
        ffmpeg -i video.mp4 -filter:a "volume=5dB" -c:v copy -c:a aac -b:a 192k output.mp4
        ffmpeg -i video.mp4 -af "volume=5dB" -c:v copy -c:a aac -b:a 192k output.mp4
        ffmpeg -i video.mp4 -af loudnorm=I=-10:TP=-1.5:LRA=11 -c:v copy output.mp4
        ffmpeg -i input.mp4 -af "loudnorm=I=-16:TP=-1.5:LRA=11" -c:v copy -c:a aac output.mp4
        ffmpeg -i input.mp4 -af "dynaudnorm=f=250:g=10" -c:v copy -c:a aac output.mp4
        ffmpeg -i video.mp4 -map 0 -c copy -c:a aac -af "volume=5dB" output.mp4
        ffmpeg -i video.mp4 -map 0 -c:v copy -af loudnorm=I=-10:TP=-1.5:LRA=11 output.mp4
        ffmpeg -i video.mp4 -map 0 -c:v copy -c:a aac -af "dynaudnorm=f=150:g=5" output.mp4
    
        ffmpeg -i video.mp4 -filter:a "volumedetect" -map 0:a -f null /dev/nul
        ffmpeg -i video.mp4 -af "volumedetect" -vn -sn -dn -f null NUL
    */
    #endregion
}
