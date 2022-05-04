namespace Lab4
{
    internal class ByType
    {
        public Images images = new Images();
        public Audio audio = new Audio();
        public Video video = new Video();
        public Document document = new Document();
        public Other other = new Other();

        public override string ToString()
        {
            string result = "";

            result += "Files:\n";
            result += "\tBy types:\n";
            result +=
                "" +
                "\t\t\t\t[count]" +
                "\t[total size]" +
                "\t[avg size]" +
                "\t[min size]" +
                "\t[max size]\n";
            result += $"" +
                $"\t\t{FileType.images}" +
                $"\t\t{images.getCount}" +
                $"\t{images.getSize()}" +
                $"\t\t{images.AvgSize()}" +
                $"\t\t{images.getMinValue()}" +
                $"\t\t{images.getMinValue()}\n";
            result += $"" +
                $"\t\t{FileType.audio}" +
                $"\t\t{audio.getCount}" +
                $"\t{audio.getSize()}" +
                $"\t\t{audio.AvgSize()}" +
                $"\t\t{audio.getMinValue()}" +
                $"\t\t{audio.getMinValue()}\n";
            result += $"" +
                $"\t\t{FileType.video}" +
                $"\t\t{video.getCount}" +
                $"\t{video.getSize()}" +
                $"\t\t{video.AvgSize()}" +
                $"\t\t{video.getMinValue()}" +
                $"\t\t{video.getMinValue()}\n";
            result += $"" +
                $"\t\t{FileType.document}" +
                $"\t{document.getCount}" +
                $"\t{document.getSize()}" +
                $"\t\t{document.AvgSize()}" +
                $"\t\t{document.getMinValue()}" +
                $"\t\t{document.getMinValue()}\n";
            result += $"" +
               $"\t\t{FileType.other}" +
               $"\t\t{other.getCount}" +
               $"\t{other.getSize()}" +
               $"\t\t{other.AvgSize()}" +
               $"\t\t{other.getMinValue()}" +
               $"\t\t{other.getMinValue()}\n";

            return result;
        }
    }
}
