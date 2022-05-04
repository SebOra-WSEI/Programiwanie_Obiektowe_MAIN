using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Other
    {
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
    }
}

enum OtherExtension
{
    other
}
