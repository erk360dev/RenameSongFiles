using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameSongsFiles
{
    public static class VideoHelper
    {
        public static string FFmpegPath { get; set; }
        public static FFmpegHandle FFmpegHandle { get; set; }

        public static string LocalTempUser { get; set; }       
    }
}
