using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace DownloadYoutubeVideo
{
    class DownloadAndGetInfo : CommadVideo
    {
        Receiver receiver;
        YoutubeClient youtube;

        public DownloadAndGetInfo(Receiver receiver , YoutubeClient youtube)
        {
            this.receiver = receiver;
            this.youtube = youtube;
        }

        public async override void DownloadVideo(string videoUrl, string outputFilePath)
        {
             var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var steamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await youtube.Videos.Streams.DownloadAsync(steamInfo, $"video.{steamInfo.Container}");
        }

        public override void GetInfoVideo(string videoUrl)
        {
            youtube.Videos.GetAsync(videoUrl);
        }
    }
}
