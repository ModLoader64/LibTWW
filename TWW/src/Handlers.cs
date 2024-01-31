using System.Runtime.InteropServices;

namespace TWW;

public class Handlers
{

    [OnEmulatorStart]
    public static void OnEmulatorStarted(EventEmulatorStart e)
    {
        Console.WriteLine("[TWW] Emulator Started.");
    }

}
