using System;
using System.Runtime.InteropServices;
using System.Security;

namespace vkpars.Helpers
{
    public static class Helpers
    {
        // Не делайте так =)
        public static string ConvertToUnsecureString(this SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}