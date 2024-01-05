namespace Rayman3GBABizHawkTool;

public class Rayman3_FocusGroup_20020318 : Game
{
    public override string Name => "Rayman 3 - Focus Group (2002/03/18)";

    public override int MemoryManagerAddress => 0x03002724;

    public override int NextFrameAddress => 0x03002494;
    public override int NextFrameSizeAddress => 0x0300249a;
    public override Frame[] Frames => new Frame[]
    {
        new(0x0801cea8, 0x14, "Ubisoft Logo"),
        new(0x08000290, 0x10, "Game Logo"),
        new(0x0801b954, 0xc,  "Map 0"),
        new(0x0801bb94, 0xc,  "Map 1"),
        new(0x0801bdc8, null, "Map 2 (Unused)"),
        new(0x0801bff0, 0xc,  "Map 3 (Unused)"),
        new(0x0801c218, 0xc,  "Map 4"),
        new(0x0801c440, 0xc,  "Map 5"),
        new(0x0801c638, null, "Map 6 (Unused)"),
        new(0x0801c860, 0xc,  "Map 7 (Unused)"),
        new(0x0801ca88, 0xc,  "Map 8 (Unused)"),
        new(0x0801ccb0, 0xc,  "Map 9 (Unused)"),
        new(0x0801ccce, null, "Map 10"),
    };

    public override int JoypadScanCallAddress => 0x0800023c;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x2c, 0xf0, 0xca, 0xfe };
}