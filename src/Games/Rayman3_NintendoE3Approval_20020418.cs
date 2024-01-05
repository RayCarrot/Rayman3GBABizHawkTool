namespace Rayman3GBABizHawkTool;

public class Rayman3_NintendoE3Approval_20020418 : Game
{
    public override string Name => "Rayman 3 - Nintendo E3 Approval (2002/04/18)";

    public override int MemoryManagerAddress => 0x03002250;

    public override int NextFrameAddress => 0x03002094;
    public override int NextFrameSizeAddress => 0x0300209a;
    public override Frame[] Frames => new Frame[]
    {
        new(0x0802fb10, 0x18, "Ubisoft Logo"),
        new(0x080011b8, 0x8,  "Title Screen"),
        new(0x080006d0, 0x44, "Main Menu"),
        //new(0x080009c0, null, "?"), // Crashes
        new(0x0800110c, null, "GameCube Link (Unused)"),
        new(0x0802d15c, 0x10, "Map 0"),
        new(0x0802d550, 0x10, "Map 1"),
        new(0x0802d91c, 0x10, "Map 2"),
        new(0x0802dd10, null, "Map 3 (Unused)"),
        new(0x0802e6e8, null, "Map 4 (Unused)"),
        new(0x0802e9e4, 0x10, "Map 5"),
        new(0x0802f598, 0x10, "Map 6"),
        new(0x0802f5b0, null, "Map 7 (Unused)"),
        new(0x0802e0cc, 0x14, "Map 8"),
        new(0x0802e3e0, null, "Map 9 (Unused)"),
        new(0x0802ecf0, 0x10, "Map 10 (Unused)"),
        new(0x0802efb4, null, "Map 11 (Unused)"),
        //new(0x0802efde, null, "Map 12 (Unused)"), // Doesn't load
    };

    public override int JoypadScanCallAddress => 0x08000284;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x42, 0xf0, 0x4e, 0xfa };
}