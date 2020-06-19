using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace vkpars.Service
{
    public class LoggerFile : ILogger
    {
        private readonly string FILELOG = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
        private readonly object _lock = new object();
        public void AddLog(string message, [CallerMemberName] string memberName = "")
        {
            lock (_lock)
            {
                try
                {
                    File.AppendAllLines(FILELOG, new[] 
                    { 
                        $"{DateTime.Now} {memberName}",
                        $"{DateTime.Now} {message}"
                    });
                }
                catch { }
            }       
        }
    }
}