using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DownloadYoutubeVideo
{
    class DownloadAndGetInfo : CommadVideo
    {
        Receiver receiver;

        public DownloadAndGetInfo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        async public override void DownloadVideo(string videoUrl, string outputFilePath)
        {
           
        }

        async public override void GetInfoVideo(string videoUrl)
        {

        }
    }
}
