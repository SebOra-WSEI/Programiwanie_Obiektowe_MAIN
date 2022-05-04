using System.Collections.Generic;

namespace Lab4
{
    internal class Document
    {
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