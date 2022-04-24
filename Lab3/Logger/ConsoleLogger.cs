using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Logger
{
    internal class ConsoleLogger: WritterLogger
    {
        public ConsoleLogger()
        {
            base.writer = Console.Out;
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
