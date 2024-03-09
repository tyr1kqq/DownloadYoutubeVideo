using System.Reflection;

namespace DownloadYoutubeVideo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string VideoUrl, OutputFilePath ;

            OutputFilePath = @"C://Users/tyr1k_qq/source/repos/DownloadYoutubeVideo/DownloadYoutubeVideo/bin/Debug/net6.0";
            Console.WriteLine("Введите ссылку на видео");
            VideoUrl = Console.ReadLine();
            
            var sender = new SenderVideo();

            
            var receiver = new Receiver();

            
            var downloadAndGetInfo = new DownloadAndGetInfo(receiver);

            
            sender.SetCommand(downloadAndGetInfo);

            sender.GetInfoVideo(VideoUrl);
            sender.DownloadVideo(VideoUrl , OutputFilePath );
        }
    }
}