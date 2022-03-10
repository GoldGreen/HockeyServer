using HockeyServer.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyServer.Services.Abstractions
{
    public interface IPythonInitService
    {
        void Start(VideoInfoDto videoInfoDto);
    }
}
