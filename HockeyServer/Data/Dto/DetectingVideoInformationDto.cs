using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyServer.Data.Dto
{
    public class DetectingVideoInformationDto
    {
        public string Path { get; set; }
        public int FramesCount { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
