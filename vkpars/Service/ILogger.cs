using System.Runtime.CompilerServices;

namespace vkpars.Service
{
    public interface ILogger
    {
        void AddLog(string message, [CallerMemberName] string memberName = "");
    }
}