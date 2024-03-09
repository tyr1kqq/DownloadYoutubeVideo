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

        public override async Task DownloadVideo(string videoUrl, string outputFilePath)
        {
             var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var steamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(steamInfo, $"{outputFilePath}video.{steamInfo.Container}");
            receiver.Operation();
        }

        public override async Task GetInfoVideo(string videoUrl)
        {
            var video = await youtube.Videos.GetAsync(videoUrl);
            await Console.Out.WriteLineAsync("Название видео - " + video.Title + "\n" + "Описание видео - " + video.Description );

            receiver.Operation();
        }
    }
}
