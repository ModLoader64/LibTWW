using System.Runtime.InteropServices;
using System;
using TWW.API;
using ImGuiNET;
using System.Security.Cryptography;

namespace TWW;

[Plugin("TWW")]
public class TheWindWaker : IPlugin
{
    public static void Destroy()
    {
        Console.WriteLine("TWW Destroy");
    }

    public static void Init()
    {
        Console.WriteLine("TWW Init");
    }
}

[BootstrapFilter]
public class Core : IBootstrapFilter
{

    public static dComIfG_inf_c? gameInfo;

    public static bool isReady = false;

    public static u16 lastRupees = 0;

    public static bool DoesLoad(byte[] e)
    {
        return true;
    }

    public static void InitTWW()
    {
        gameInfo = new dComIfG_inf_c(0x803C4C08);

        isReady = true;
    }

    [OnInit]
    public static void OnInit(EventPluginsLoaded evt)
    {
        Console.WriteLine("TWW Core: Init");
        InitTWW();
    }

    public static void Destroy()
    {
        Console.WriteLine("Destroy");
    }

    [OnFrame]
    public static void OnTick(EventNewFrame e)
    {
        if (!isReady) { return; }

        /*u16 curRupees = gameInfo.save.mSavedata.mPlayer.mPlayerStatusA.mRupee;
        if (curRupees != lastRupees)
        {
            Console.WriteLine("Obtained " + (curRupees - lastRupees) + " Rupees. Total: " + curRupees);
            lastRupees = curRupees;
        }*/

    }

    [OnViUpdate]
    public static void OnViUpdate(EventNewVi e)
    {
        ImGui.BeginMainMenuBar();
        if (ImGui.BeginMenu("File"))
        {
            if (ImGui.MenuItem("Say hello"))
            {
                ImGui.Text("hello");
            }
            ImGui.EndMenu();
        }
        ImGui.EndMainMenuBar();

        if (ImGui.Begin("Rupees"))
        {
            int rupees = Memory.RAM.ReadU8(0x803c4c0c) << 8 | Memory.RAM.ReadU8(0x803c4c0d);
            ImGui.Text($"Rupees: {rupees}");
            ImGui.End();
        }
    }

    [OnEmulatorStart]
    public static void OnEmulatorStart(EventEmulatorStart e)
    {
        //InitTWW();
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
