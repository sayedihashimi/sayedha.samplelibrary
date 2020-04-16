using System;
using System.Net.Security;

namespace SayedHa.Log {
    public class Logger : ILogger {
        private Logger() { }
        public void Debug(object message) { LogIt("Debug", message, null); }
        public void Debug(object message, Exception ex) { LogIt("Debug", message, ex); }

        public void Info(object message) { LogIt("Info", message, null); }
        public void Info(object message, Exception ex) { LogIt("Info", message, ex); }

        public void Error(object message) { LogIt("Error", message, null); }
        public void Error(object message, Exception ex) { LogIt("Error", message, ex); }

        public void Fatal(object message) { LogIt("Fatal", message, null); }
        public void Fatal(object message, Exception ex) { LogIt("Fatal", message, ex); }

        public void Verbose(object message) { LogIt("Verbose", message, null); }
        public void Verbose(object message, Exception ex) { LogIt("Verbose", message, ex); }

        protected void LogIt(string prefix, object message, Exception ex) {
            string formatstr = ex == null ? "{0}:\t{1}" : "{0}:\t{1}\tException:{2}";

            Console.WriteLine(string.Format(formatstr, prefix, message, ex));
        }

        public static ILogger GetNewLogger() {
            return new Logger();
        }
    }
}
