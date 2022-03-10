using HockeyServer.Data.Dto;
using HockeyServer.Hubs;
using HockeyServer.Services.Abstractions;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HockeyServer.Services.Implementation
{
    internal class HockeyService : IHockeyService
    {
        public IHubContext<HockeyHub> Hub { get; }
        private readonly List<FrameInfoDto> framesInfo = new();

        public HockeyService(IHubContext<HockeyHub> hub)
        {
            Hub = hub;
        }

        public async Task StartDetection(DetectingVideoInformationDto detectingVideoInformationDto)
        {
            await Hub.Clients.All.SendAsync("DetectionStarted", detectingVideoInformationDto);
        }

        public async Task AddFrameInfo(FrameInfoDto frameInfoDto)
        {
            framesInfo.Add(frameInfoDto);
            await Hub.Clients.All.SendAsync("FrameReaded", frameInfoDto.FrameNum);
        }

        public IEnumerable<FrameInfoDto> GetFrames()
        {
            return framesInfo;
        }
    }
}
