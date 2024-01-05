namespace Rayman3GBABizHawkTool;

public class Rayman3_E3_20020516 : Game
{
    public override string Name => "Rayman 3 - E3 (2002/05/16)";

    public override int MemoryManagerAddress => 0x03002280;

    public override int NextFrameAddress => 0x030020c4;
    public override int NextFrameSizeAddress => 0x030020ca;
    public override Frame[] Frames => new Frame[]
    {
        new(0x0803cea8, 0x18, "Ubisoft Logo"),
        new(0x0800297c, 0x8,  "Title Screen"),
        new(0x0800090c, 0x10, "Main Menu"),
        new(0x08000fe4, 0x44, "GameCube Link"),
        new(0x0803957c, 0x20, "Map 0"),
        new(0x08039980, 0x20, "Map 1"),
        new(0x08039d5c, null, "Map 2 (Unused)"),
        //new(0x0803a160, null, "Map 3 (Unused)"), // Doesn't load
        new(0x0803c04c, 0x20, "Map 4"),
        new(0x0803bd0c, 0xc,  "Map 5"),
        new(0x0803ae20, null, "Map 6 (Unused)"),
        new(0x0803b4a8, 0x24, "Map 7"),
        new(0x0803c620, 0x20, "Map 8"),
        new(0x0803c638, null, "Map 9 (Unused)"),
        new(0x0803a5cc, 0x28, "Map 10"),
        new(0x0803ab50, null, "Map 11 (Unused)"),
        new(0x0803b784, 0x20, "Map 12 (Unused)"),
        //new(0x0803ba48, null, "Map 13 (Unused)"), // Doesn't load
        new(0x0803cc6c, null, "Map 14 (Unused)"),
        new(0x0803cc84, 0x20, "Map 15"),
    };

    public override int JoypadScanCallAddress => 0x08000288;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x4d, 0xf0, 0xd2, 0xfe };
}