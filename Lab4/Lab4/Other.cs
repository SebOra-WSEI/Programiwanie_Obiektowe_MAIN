using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Other
    {
        public double size;
        public List<File<OtherExtension>> otherList;
        public Other()
        {
            otherList = new List<File<OtherExtension>>()
            {
            new File<OtherExtension>("file1", 9.0, FileType.other, OtherExtension.other),
            new File<OtherExtension>("file1", 0.1, FileType.other, OtherExtension.other),
            new File<OtherExtension>("file1", 2.2, FileType.other, OtherExtension.other),
            };
        }

        public int getCount => otherList.Count;
        public double getSize()
        {
            foreach (var item in otherList) { size += item.fileSize; }
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

            foreach (var item in otherList)
            {
                if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }

        public double getMinValue()
        {
            double min = otherList[0].fileSize;

            foreach (var item in otherList)
            {
                if (item.fileSize < min) min = item.fileSize;
            }
            return min;
        }
    }
}

enum OtherExtension
{
    other
}
