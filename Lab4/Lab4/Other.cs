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

        public int getSpecificCount(OtherExtension extension)
        {
            int count = 0;
            foreach (var item in otherList)
            {
                if (item.extension == extension) count++;
            }
            return count;
        }

        public double getSpecificSize(OtherExtension extension)
        {
            double size = 0;
            foreach (var item in otherList)
            {
                if (item.extension == extension) size += item.fileSize;
            }
            return Math.Round(size, 2);
        }
        public double getSpecificAvg(OtherExtension extension)
        {
            double size = 0;
            foreach (var item in otherList)
            {
                if (item.extension == extension) size += item.fileSize;
            }
            return Math.Round(size / getSpecificCount(extension));
        }

        public double getSpecificMaxValue(OtherExtension extension)
        {
            double max = 0.0;

            foreach (var item in otherList)
            {
                if (item.extension == extension)
                    if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }
        public double getSpecificMinValue(OtherExtension extension)
        {
            double min = 10000000000000;

            foreach (var item in otherList)
            {
                if (item.extension == extension)
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
