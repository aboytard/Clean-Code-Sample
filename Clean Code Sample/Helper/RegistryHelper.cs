using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Clean_Code_Sample.Helper
{
    public static class RegistryHelper
    {
        private static string Root = "HKEY_LOCAL_MACHINE";
        private static string Path = "Path in the registry";


        public static string GetInstallationRegistryValueWithSubPath(string subPath, string registryKey, string defaultValue = null)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Registry.GetValue($"{Root}\\{Path}\\{subPath}", registryKey, defaultValue).ToString();
            }
            throw new NotSupportedException("Current platform is not windows");
        }

        public static string GetInstallationRegistryValue(string registryKey, string defaultValue = null)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Registry.GetValue($"{Root}\\{Path}", registryKey, defaultValue)?.ToString();
            }
            throw new NotSupportedException("Current platform is not windows");
        }
    }
}
