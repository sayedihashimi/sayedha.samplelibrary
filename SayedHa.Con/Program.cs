using System;
using SayedHa.Log;

namespace SayedHa.Con {
    class Program {
        private ILogger logger = Logger.GetNewLogger();

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
