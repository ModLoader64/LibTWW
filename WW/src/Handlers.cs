using System.Runtime.InteropServices;

namespace WW;

public class Handlers
{

    [OnEmulatorStart]
    public static void OnEmulatorStarted(EventEmulatorStart e)
    {
        Console.WriteLine("[WW] Emulator Started.");
    }

}
