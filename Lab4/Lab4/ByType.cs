using System.Collections.Generic;
using System.IO;

namespace Lab4
{
    internal class ByType
    {
        public Images images;
        public Audio audio;
        public Video video;
        public Document document;
        public ByType()
        {
            images = new Images();
            audio = new Audio();
            video = new Video();
            document = new Document();
        }
    }
}
