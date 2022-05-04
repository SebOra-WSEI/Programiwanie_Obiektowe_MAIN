using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Images
    {
        public List<File<ImageExtension>> imageList;
        public double size;

        public Images()
        {
            imageList = new List<File<ImageExtension>>()
            {
            new File<ImageExtension>("file1", 9.0, FileType.images, ImageExtension.tiff),
            new File<ImageExtension>("file1", 0.1, FileType.images, ImageExtension.png),
            new File<ImageExtension>("file1", 2.2, FileType.images, ImageExtension.png),
            new File<ImageExtension>("file1", 3.3, FileType.images, ImageExtension.png),
            new File<ImageExtension>("file1", 4.4, FileType.images, ImageExtension.png),
            new File<ImageExtension>("file1", 1.2, FileType.images, ImageExtension.webp),
            new File<ImageExtension>("file1", 3.4, FileType.images, ImageExtension.webp),
            new File<ImageExtension>("file1", 5.6, FileType.images, ImageExtension.webp),
            new File<ImageExtension>("file1", 9.0, FileType.images, ImageExtension.webp),
            new File<ImageExtension>("file1", 9.0, FileType.images, ImageExtension.jpg),
            new File<ImageExtension>("file1", 9.0, FileType.images, ImageExtension.gif),
            new File<ImageExtension>("file1", 9.0, FileType.images, ImageExtension.gif),
            new File<ImageExtension>("file1", 9.0, FileType.images, ImageExtension.tiff),
            };
        }

        public int getCount =>  imageList.Count;
        public double getSize()
        {
            foreach (var item in imageList) { size += item.fileSize; }
            return Math.Round(size, 2);
        }

        public double AvgSize()
        {
            getSize();
            return  Math.Round(size / getCount, 2);
        }

        public double getMaxValue()
        {
            double max = 0.0;

            foreach (var item in imageList)
            {
                if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }

        public double getMinValue()
        {
            double min = imageList[0].fileSize;

            foreach (var item in imageList)
            {
                if (item.fileSize < min) min = item.fileSize;
            }
            return min;
        }
    }
}

enum ImageExtension
{
    png,
    webp,
    jpg,
    gif,
    tiff
}