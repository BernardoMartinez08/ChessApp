using ChessApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Infrastructure.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string text) => File.AppendAllText("log.txt", text +"\n");
    }
}
