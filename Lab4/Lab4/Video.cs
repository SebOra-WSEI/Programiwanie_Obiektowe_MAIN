using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Video
    {
        public double size;
        public List<File<VideoExtension>> videoList;
        public Video()
        {
            videoList = new List<File<VideoExtension>>()
            {
            new File<VideoExtension>("file1", 9.0, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 0.1, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 2.2, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 3.3, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 4.4, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 1.2, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 3.4, FileType.video, VideoExtension.mp4),
            new File<VideoExtension>("file1", 5.6, FileType.video, VideoExtension.webm),
            new File<VideoExtension>("file1", 9.0, FileType.video, VideoExtension.webm),
            };
        }

        public int getCount => videoList.Count;
        public double getSize()
        {
            foreach (var item in videoList) { size += item.fileSize; }
            return Math.Round(size, 2);
        }

        public double AvgSize()
        {
            getSize();
            return Math.Round(size / getCount, 2);
        }

        public double getMaxValue()
        {
            double max = 0.0;

            foreach (var item in videoList)
            {
                if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }

        public double getMinValue()
        {
            double min = videoList[0].fileSize;

            foreach (var item in videoList)
            {
                if (item.fileSize < min) min = item.fileSize;
            }
            return min;
        }
    }
}
 enum VideoExtension
{
    mkv,
    mp4,
    webm
}