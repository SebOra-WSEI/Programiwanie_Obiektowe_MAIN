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
            new File<AudioExtension>("file1", 9.0, FileType.audio, AudioExtension.ogg),
            new File<AudioExtension>("file1", 0.1, FileType.audio, AudioExtension.ogg),
            new File<AudioExtension>("file1", 2.2, FileType.audio, AudioExtension.ogg),
            new File<AudioExtension>("file1", 3.3, FileType.audio, AudioExtension.mp3),
            new File<AudioExtension>("file1", 4.4, FileType.audio, AudioExtension.mp3),
            new File<AudioExtension>("file1", 1.2, FileType.audio, AudioExtension.mp3),
            new File<AudioExtension>("file1", 3.4, FileType.audio, AudioExtension.mp3),
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
    }
}

enum AudioExtension
{
    ogg,
    mp3
}
