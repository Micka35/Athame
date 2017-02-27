﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athame.PluginAPI.Downloader;
using Athame.PluginAPI.Service;

namespace Athame.DownloadAndTag
{
    public class EnqueuedTrack
    {
        internal EnqueuedTrack()
        {
            
        }

        public Track Track { get; set; }
        public MusicService Service { get; set; }
    }
}
