using System.Security;
using vkpars.Helpers;

namespace vkpars.Data
{
    public class SettingsConnect
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string UserId { get; set; }
        public SecureString Password { get; set; }
        public string Database { get; set; }
        public int Timeout { get; set; }
        public int CommandTimeout { get; set; }

        public string GetConnectString()
        {
           return $"Server={Server};Port={Port};User Id={UserId};Password={Password.ConvertToUnsecureString()};Database={Database};Timeout={Timeout};CommandTimeout={CommandTimeout};";
        }
    }
}