using System;

namespace Lab3.Logger
{
    internal class CommonLogger: ILogger
    {
        private ILogger[] Loggers;
        public CommonLogger(ILogger[] loggers)
        {
            Loggers = loggers;
        }

        public void Log(params string[] messages)
        {
            foreach (var loger in Loggers)
                loger.Log(messages);
        }

        public void Dispose()
        {
            foreach (var logger in Loggers)
                logger.Dispose();
        }
    }
}
