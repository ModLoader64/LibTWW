using System.Runtime.InteropServices;
using System;
using WW.API;
using WW.API.src;

namespace WW;

[Plugin("WW")]
public class WindWaker : IPlugin
{
    public static void Destroy()
    {
        Console.WriteLine("WW Destroy");
    }

    public static void Init()
    {
        Console.WriteLine("WW Init");
    }
}

[BootstrapFilter]
public class Core : IBootstrapFilter
{

    public static dComIfG_inf_c? game;

    public static bool isReady = false;

    public static u16 lastRupees = 0;

    public static bool DoesLoad(byte[] e)
    {
        return true;
    }

    public static void InitWW()
    {
        game = new dComIfG_inf_c(0x803C4C08);

        isReady = true;
    }

    [OnInit]
    public static void OnInit(EventPluginsLoaded evt)
    {
        Console.WriteLine("WW Core: Init");
    }

    public static void Destroy()
    {
        Console.WriteLine("Destroy");
    }

    [OnFrame]
    public static void OnTick(EventNewFrame e)
    {
        if (!isReady) { return; }

        u16 curRupees = game.save.mSavedata.mPlayer.mPlayerStatusA.mRupee;
        if (curRupees != lastRupees)
        {
            Console.WriteLine("Obtained " + (curRupees - lastRupees) + " Rupees. Total: " + curRupees);
            lastRupees = curRupees;
        }

    }

    [OnViUpdate]
    public static void OnViUpdate(EventNewVi e)
    {
    }

    [OnEmulatorStart]
    public static void OnEmulatorStart(EventEmulatorStart e)
    {
        InitWW();
    }

/*    [EventHandler("EventSceneChange")]
    public static void OnSceneChange(EventSceneChange evt)
    {

    }*/

    /*[EventHandler("EventRomLoaded")]
    public static void OnRomLoaded(EventRomLoaded e)
    {
        Console.WriteLine("OnRomLoaded GetRomHeader");
        var header = new u8[0x40];
        Array.Copy(e.rom, header, 0x40);
        GCHandle pinnedBytes = GCHandle.Alloc(header, GCHandleType.Pinned);
        romHeader = (N64RomHeader)Marshal.PtrToStructure(pinnedBytes.AddrOfPinnedObject(), typeof(N64RomHeader));
        pinnedBytes.Free();
    }*/
}
