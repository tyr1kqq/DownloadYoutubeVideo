using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace DownloadYoutubeVideo
{
    abstract class CommadVideo
    {
        public abstract Task DownloadVideo(string videoUrl, string outputFilePath);
        public abstract Task GetInfoVideo(string videoUrl);

        
    }
}
