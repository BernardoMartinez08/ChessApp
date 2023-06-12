
using ChessApp.Core.Interfaces;

namespace ChessApp.Infrastructure.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string text) => Console.WriteLine(text);
    }
}
