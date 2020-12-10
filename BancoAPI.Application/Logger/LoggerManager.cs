﻿using NLog;

namespace BancoAPI.Application.Logger
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager()
        {
        }

        public void LogDebug(string msg) => logger.Debug(msg);

        public void LogError(string msg) => logger.Error(msg);

        public void LogInfo(string msg) => logger.Info(msg);

        public void LogWarn(string msg) => logger.Warn(msg);

        /*
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
        }*/
    }
}