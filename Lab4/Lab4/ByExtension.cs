using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class ByExtension
    {
        public Images images = new Images();
        public Audio audio = new Audio();
        public Video video = new Video();
        public Document document = new Document();
        public Other other = new Other();

        public override string ToString()
        {
            string result = "";

            result += "\tBy extension:\n";
            result +=
               "" +
               "\t\t\t\t[count]" +
               "\t[total size]" +
               "\t[avg size]" +
               "\t[min size]" +
               "\t[max size]\n";

            result += $"" +
               $"\t\t{ImageExtension.jpg}" +
               $"\t\t{images.getSpecificCount(ImageExtension.jpg)}" +
               $"\t{images.getSpecificSize(ImageExtension.jpg)}" +
               $"\t\t{images.getSpecificAvg(ImageExtension.jpg)}" +
               $"\t\t{images.getSpecificMinValue(ImageExtension.jpg)}" +
               $"\t\t{images.getSpecificMaxValue(ImageExtension.jpg)}\n";
            result += $"" +
               $"\t\t{ImageExtension.png}" +
               $"\t\t{images.getSpecificCount(ImageExtension.png)}" +
               $"\t{images.getSpecificSize(ImageExtension.png)}" +
               $"\t\t{images.getSpecificAvg(ImageExtension.png)}" +
               $"\t\t{images.getSpecificMinValue(ImageExtension.png)}" +
               $"\t\t{images.getSpecificMaxValue(ImageExtension.png)}\n";

            result += $"" +
               $"\t\t{VideoExtension.mkv}" +
               $"\t\t{video.getSpecificCount(VideoExtension.mkv)}" +
               $"\t{video.getSpecificSize(VideoExtension.mkv)}" +
               $"\t\t{video.getSpecificAvg(VideoExtension.mkv)}" +
               $"\t\t{video.getSpecificMinValue(VideoExtension.mkv)}" +
               $"\t\t{video.getSpecificMaxValue(VideoExtension.mkv)}\n";
            result += $"" +
               $"\t\t{VideoExtension.mp4}" +
               $"\t\t{video.getSpecificCount(VideoExtension.mp4)}" +
               $"\t{video.getSpecificSize(VideoExtension.mp4)}" +
               $"\t\t{video.getSpecificAvg(VideoExtension.mp4)}" +
               $"\t\t{video.getSpecificMinValue(VideoExtension.mp4)}" +
               $"\t\t{video.getSpecificMaxValue(VideoExtension.mp4)}\n";

            result += $"" +
               $"\t\t{AudioExtension.mp3}" +
               $"\t\t{audio.getSpecificCount(AudioExtension.mp3)}" +
               $"\t{audio.getSpecificSize(AudioExtension.mp3)}" +
               $"\t\t{audio.getSpecificAvg(AudioExtension.mp3)}" +
               $"\t\t{audio.getSpecificMinValue(AudioExtension.mp3)}" +
               $"\t\t{audio.getSpecificMaxValue(AudioExtension.mp3)}\n";

            result += $"" +
               $"\t\t{DocumentExtension.doc}" +
               $"\t\t{document.getSpecificCount(DocumentExtension.doc)}" +
               $"\t{document.getSpecificSize(DocumentExtension.doc)}" +
               $"\t\t{document.getSpecificAvg(DocumentExtension.doc)}" +
               $"\t\t{document.getSpecificMinValue(DocumentExtension.doc)}" +
               $"\t\t{document.getSpecificMaxValue(DocumentExtension.doc)}\n";

            result += $"" +
               $"\t\t{OtherExtension.other}" +
               $"\t\t{other.getSpecificCount(OtherExtension.other)}" +
               $"\t{other.getSpecificSize(OtherExtension.other)}" +
               $"\t\t{other.getSpecificAvg(OtherExtension.other)}" +
               $"\t\t{other.getSpecificMinValue(OtherExtension.other)}" +
               $"\t\t{other.getSpecificMaxValue(OtherExtension.other)}\n";

            return result;
        }
    }

}
