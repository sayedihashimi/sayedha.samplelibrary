using System;
using SayedHa.Log;

namespace SayedHa.Con {
    class Program {
        private static ILogger logger = Logger.GetNewLogger();

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            logger.Info("info here");
            logger.Debug("debug here");
            logger.Error("error here");
            logger.Fatal("fatal here");
            logger.Verbose("verbose here");
        }
    }
}
