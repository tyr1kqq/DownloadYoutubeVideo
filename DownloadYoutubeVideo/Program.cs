using System.Reflection;
using YoutubeExplode;

namespace DownloadYoutubeVideo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var youtube = new YoutubeClient();

            string VideoUrl, OutputFilePath ;

            OutputFilePath = @"C://Users/tyr1k_qq/Desktop/Video/";


            VideoUrl = "https://www.youtube.com/watch?v=GkMdejyiYjQ&ab_channel=SamJones23";
            
            var sender = new SenderVideo();

            
            var receiver = new Receiver();

            
            var downloadAndGetInfo = new DownloadAndGetInfo(receiver , youtube);

            
            sender.SetCommand(downloadAndGetInfo);

           await sender.GetInfoVideo(VideoUrl);
           await sender.DownloadVideo(VideoUrl , OutputFilePath );

            Console.ReadLine();
        }
    }
}