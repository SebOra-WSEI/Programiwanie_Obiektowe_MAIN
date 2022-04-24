using System;

namespace Lab3.Logger
{
    public interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}
