using System;

namespace SayedHa.Log {
    public interface ILogger {
        void Debug(object message);
        void Debug(object message, Exception ex);
        void Error(object message);
        void Error(object message, Exception ex);
        void Fatal(object message);
        void Fatal(object message, Exception ex);
        void Info(object message);
        void Info(object message, Exception ex);
        void Verbose(object message);
        void Verbose(object message, Exception ex);
    }
}