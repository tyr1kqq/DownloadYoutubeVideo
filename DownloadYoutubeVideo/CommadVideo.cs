using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadYoutubeVideo
{
    abstract class CommadVideo
    {
        public abstract void DownloadVideo(string videoUrl, string outputFilePath);
        public abstract void GetInfoVideo(string videoUrl);
    }
}
