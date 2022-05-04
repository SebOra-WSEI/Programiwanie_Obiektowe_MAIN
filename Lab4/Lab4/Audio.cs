using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Audio
    {
        public double size;
        public List<File<AudioExtension>> audioList;

        public Audio()
        {
            audioList = new List<File<AudioExtension>>()
            {
            new File<AudioExtension>("file1", 3.3, FileType.audio, AudioExtension.mp3),
            new File<AudioExtension>("file1", 4.4, FileType.audio, AudioExtension.mp3),
            };
        }

        public int getCount => audioList.Count;
        public double getSize()
        {
            foreach (var item in audioList) { size += item.fileSize; }
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

            foreach (var item in audioList)
            {
                if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }

        public double getMinValue()
        {
            double min = audioList[0].fileSize;

            foreach (var item in audioList)
            {
                if (item.fileSize < min) min = item.fileSize;
            }
            return min;
        }

        public int getSpecificCount(AudioExtension extension)
        {
            int count = 0;
            foreach (var item in audioList)
            {
                if (item.extension == extension) count++;
            }
            return count;
        }

        public double getSpecificSize(AudioExtension extension)
        {
            double size = 0;
            foreach (var item in audioList)
            {
                if (item.extension == extension) size += item.fileSize;
            }
            return Math.Round(size, 2);
        }
        public double getSpecificAvg(AudioExtension extension)
        {
            double size = 0;
            foreach (var item in audioList)
            {
                if (item.extension == extension) size += item.fileSize;
            }
            return Math.Round(size / getSpecificCount(extension));
        }

        public double getSpecificMaxValue(AudioExtension extension)
        {
            double max = 0.0;

            foreach (var item in audioList)
            {
                if (item.extension == extension)
                    if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }
        public double getSpecificMinValue(AudioExtension extension)
        {
            double min = 10000000000000;

            foreach (var item in audioList)
            {
                if (item.extension == extension)
                    if (item.fileSize < min) min = item.fileSize;
            }
            return min;
        }
    }
}

enum AudioExtension
{
    ogg,
    mp3
}
