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
            new File<VideoExtension>("file1", 0.1, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 2.2, FileType.video, VideoExtension.mkv),
            new File<VideoExtension>("file1", 3.3, FileType.video, VideoExtension.mp4),
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

        public int getSpecificCount(VideoExtension extension)
        {
            int count = 0;
            foreach (var item in videoList)
            {
                if (item.extension == extension) count++;
            }
            return count;
        }

        public double getSpecificSize(VideoExtension extension)
        {
            double size = 0;
            foreach (var item in videoList)
            {
                if (item.extension == extension) size += item.fileSize;
            }
            return Math.Round(size, 2);
        }
        public double getSpecificAvg(VideoExtension extension)
        {
            double size = 0;
            foreach (var item in videoList)
            {
                if (item.extension == extension) size += item.fileSize;
            }
            return Math.Round(size / getSpecificCount(extension));
        }

        public double getSpecificMaxValue(VideoExtension extension)
        {
            double max = 0.0;

            foreach (var item in videoList)
            {
                if (item.extension == extension)
                    if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }
        public double getSpecificMinValue(VideoExtension extension)
        {
            double min = 10000000000000;

            foreach (var item in videoList)
            {
                if (item.extension == extension)
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