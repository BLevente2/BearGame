using System.Runtime.Versioning;

namespace BeaverGame;

public static class Program
{
    [SupportedOSPlatform("windows")]
    [STAThread]
    public static void Main()
    {
        if (OperatingSystem.IsWindows())
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new BeaverGameProject());
        }
        else
        {
            throw new PlatformNotSupportedException("Ez az alkalmaz�s csak Windows rendszeren futtathat�.");
        }
    }
}