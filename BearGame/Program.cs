using System.Runtime.Versioning;

namespace BearGame;

public static class Program
{
    [SupportedOSPlatform("windows")]
    [STAThread]
    public static void Main()
    {
        if (OperatingSystem.IsWindows())
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new BearGameProject());
        }
        else
        {
            throw new PlatformNotSupportedException("Ez az alkalmazás csak Windows rendszeren futtatható.");
        }
    }
}