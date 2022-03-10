using HockeyServer.Data.Dto;
using HockeyServer.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyServer.Services.Implementation
{
    internal class PythonInitService : IPythonInitService
    {
        public void Start(VideoInfoDto videoInfoDto)
        {
            ProcessStartInfo pythonInfo = new();
            pythonInfo.FileName = @"C:/Users/Admin/AppData/Local/Programs/Python/Python36/python.exe";
            pythonInfo.Arguments = $@"F:/VisualStudio/yolov4-deepsort-master/object_tracker.py --video {videoInfoDto.FileName}";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;

            var python = Process.Start(pythonInfo);
        }
    }
}
