using HockeyServer.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyServer.Services.Abstractions
{
    public interface IHockeyService
    {
        IEnumerable<FrameInfoDto> GetFrames();
        Task StartDetection(DetectingVideoInformationDto detectingVideoInformationDto);
        Task AddFrameInfo(FrameInfoDto frameInfoDto);
    }
}
