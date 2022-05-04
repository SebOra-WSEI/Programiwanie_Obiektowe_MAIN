using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Document
    {
        public double size;
        public List<File<DocumentExtension>> docsList;
        public Document()
        {
            docsList = new List<File<DocumentExtension>>()
            {
            new File<DocumentExtension>("file1", 9.0, FileType.document, DocumentExtension.txt),
            new File<DocumentExtension>("file1", 0.1, FileType.document, DocumentExtension.txt),
            new File<DocumentExtension>("file1", 2.2, FileType.document, DocumentExtension.txt),
            new File<DocumentExtension>("file1", 3.3, FileType.document, DocumentExtension.doc),
            new File<DocumentExtension>("file1", 4.4, FileType.document, DocumentExtension.doc),
            new File<DocumentExtension>("file1", 9.0, FileType.document, DocumentExtension.doc),
            new File<DocumentExtension>("file1", 9.0, FileType.document, DocumentExtension.xml),
            new File<DocumentExtension>("file1", 9.0, FileType.document, DocumentExtension.xml),
            new File<DocumentExtension>("file1", 9.0, FileType.document, DocumentExtension.xlmx),
            };
        }
        public int getCount => docsList.Count;
        public double getSize()
        {
            foreach (var item in docsList) { size += item.fileSize; }
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

            foreach (var item in docsList)
            {
                if (item.fileSize > max) max = item.fileSize;
            }
            return max;
        }

        public double getMinValue()
        {
            double min = docsList[0].fileSize;

            foreach (var item in docsList)
            {
                if (item.fileSize < min) min = item.fileSize;
            }
            return min;
        }
    }
}

enum DocumentExtension
{
    txt,
    doc,
    docx,
    xml,
    xlmx,
}