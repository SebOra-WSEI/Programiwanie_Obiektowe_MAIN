using System;
using System.IO;

namespace Lab3.Logger
{
    internal class FileLogger: WritterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            stream = new FileStream(path, FileMode.Append);
            writer = new StreamWriter(stream);
        }
        ~FileLogger()
        {
            Dispose(disposing: false);
        }
        public override void Dispose()
        {
            writer.Close();
            writer.Dispose();
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    Dispose();
            disposed = true;
        }
    }
}
