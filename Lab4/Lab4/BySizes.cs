namespace Lab4
{
    internal class BySizes
    {
        public Images images = new Images();
        public Audio audio = new Audio();
        public Video video = new Video();
        public Document document = new Document();
        public Other other = new Other();

        public override string ToString()
        {
            double size1 = 0.1;
            double size2 = 0.6;
            double size3 = 1.0;
            double size4 = 2.0;
            double size5 = 5.0;
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
                $"\t\t{size1} < _ < {size2}" +
                $"\t{images.getCountBySize(size1, size2) + audio.getCountBySize(size1, size2) + document.getCountBySize(size1, size2) + other.getCountBySize(size1, size2) + video.getCountBySize(size1, size2)}" +
                $"\t{images.getSizeBySize(size1, size2) + audio.getSizeBySize(size1, size2) + document.getSizeBySize(size1, size2) + other.getSizeBySize(size1, size2) + video.getSizeBySize(size1, size2)}" +
                $"\t\t{images.getAvgBySize(size1, size2) + audio.getAvgBySize(size1, size2) + document.getAvgBySize(size1, size2) + other.getAvgBySize(size1, size2) + video.getAvgBySize(size1, size2)}" +
                $"\t\t{images.getSpecificMinValueBySize(size1, size2) + audio.getSpecificMinValueBySize(size1, size2) + document.getSpecificMinValueBySize(size1, size2) + other.getSpecificMinValueBySize(size1, size2) + video.getSpecificMinValueBySize(size1, size2)}" +
                $"\t\t{images.getSpecificMaxValueBySize(size1, size2) + audio.getSpecificMaxValueBySize(size1, size2) + document.getSpecificMaxValueBySize(size1, size2) + other.getSpecificMaxValueBySize(size1, size2) + video.getSpecificMaxValueBySize(size1, size2)}\n";

            result += $"" +
                $"\t\t{size3} < _ < {size4}" +
                $"\t{images.getCountBySize(size2, size3) + audio.getCountBySize(size2, size3) + document.getCountBySize(size2, size3) + other.getCountBySize(size2, size3) + video.getCountBySize(size2, size3)}" +
                $"\t{images.getSizeBySize(size2, size3) + audio.getSizeBySize(size2, size3) + document.getSizeBySize(size2, size3) + other.getSizeBySize(size2, size3) + video.getSizeBySize(size2, size3)}" +
                $"\t\t{images.getAvgBySize(size2, size3) + audio.getAvgBySize(size2, size3) + document.getAvgBySize(size2, size3) + other.getAvgBySize(size2, size3) + video.getAvgBySize(size2, size3)}" +
                $"\t\t{images.getSpecificMinValueBySize(size2, size3) + audio.getSpecificMinValueBySize(size2, size3) + document.getSpecificMinValueBySize(size2, size3) + other.getSpecificMinValueBySize(size2, size3) + video.getSpecificMinValueBySize(size2, size3)}" +
                $"\t\t{images.getSpecificMaxValueBySize(size2, size3) + audio.getSpecificMaxValueBySize(size2, size3) + document.getSpecificMaxValueBySize(size2, size3) + other.getSpecificMaxValueBySize(size2, size3) + video.getSpecificMaxValueBySize(size2, size3)}\n";

            result += $"" +
                $"\t\t{size3} < _ < {size4}" +
                $"\t{images.getCountBySize(size3, size4) + audio.getCountBySize(size3, size4) + document.getCountBySize(size3, size4) + other.getCountBySize(size3, size4) + video.getCountBySize(size3, size4)}" +
                $"\t{images.getSizeBySize(size3, size4) + audio.getSizeBySize(size3, size4) + document.getSizeBySize(size3, size4) + other.getSizeBySize(size3, size4) + video.getSizeBySize(size3, size4)}" +
                $"\t\t{images.getAvgBySize(size3, size4) + audio.getAvgBySize(size3, size4) + document.getAvgBySize(size3, size4) + other.getAvgBySize(size3, size4) + video.getAvgBySize(size3, size4)}" +
                $"\t\t{images.getSpecificMinValueBySize(size3, size4) + audio.getSpecificMinValueBySize(size3, size4) + document.getSpecificMinValueBySize(size3, size4) + other.getSpecificMinValueBySize(size3, size4) + video.getSpecificMinValueBySize(size3, size4)}" +
                $"\t\t{images.getSpecificMaxValueBySize(size3, size4) + audio.getSpecificMaxValueBySize(size3, size4) + document.getSpecificMaxValueBySize(size3, size4) + other.getSpecificMaxValueBySize(size3, size4) + video.getSpecificMaxValueBySize(size3, size4)}\n";
            result += $"" +
                $"\t\t{size4}  < _ <  {size5}" +
                $"\t{images.getCountBySize(size4, size5) + audio.getCountBySize(size4, size5) + document.getCountBySize(size4, size5) + other.getCountBySize(size4, size5) + video.getCountBySize(size4, size5)}" +
                $"\t{images.getSizeBySize(size4, size5) + audio.getSizeBySize(size4, size5) + document.getSizeBySize(size4, size5) + other.getSizeBySize(size4, size5) + video.getSizeBySize(size4, size5)}" +
                $"\t\t{images.getAvgBySize(size4, size5) + audio.getAvgBySize(size4, size5) + document.getAvgBySize(size4, size5) + other.getAvgBySize(size4, size5) + video.getAvgBySize(size4, size5)}" +
                $"\t\t{images.getSpecificMinValueBySize(size4, size5) + audio.getSpecificMinValueBySize(size4, size5) + document.getSpecificMinValueBySize(size4, size5) + other.getSpecificMinValueBySize(size4, size5) + video.getSpecificMinValueBySize(size4, size5)}" +
                $"\t\t{images.getSpecificMaxValueBySize(size4, size5) + audio.getSpecificMaxValueBySize(size4, size5) + document.getSpecificMaxValueBySize(size4, size5) + other.getSpecificMaxValueBySize(size4, size5) + video.getSpecificMaxValueBySize(size4, size5)}\n";


            return result;
        }
    }
}
