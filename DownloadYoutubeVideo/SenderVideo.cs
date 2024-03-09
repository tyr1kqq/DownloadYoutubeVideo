using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadYoutubeVideo
{
    class SenderVideo
    {
        CommadVideo _commadVideo;

        public void SetCommand( CommadVideo commadVideo )
        {
            _commadVideo = commadVideo;
        }

        public async Task DownloadVideo(string videoUrl, string outputFilePath)
        {
            _commadVideo.DownloadVideo(videoUrl, outputFilePath);
        }

        public async Task GetInfoVideo(string videoUrl)
        {
            _commadVideo.GetInfoVideo(videoUrl);
        }
        
    }
}
