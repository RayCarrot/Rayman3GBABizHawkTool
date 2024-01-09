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
        new(0x08000290, 0x10, "Title Screen"),

        new(0x0801b954, 0xc,  "Map 0 - The Woods of Light"),
        new(0x0801bb94, 0xc,  "Map 1 - The Woods of Light"),
        new(0x0801bdc8, 0xc,  "Map 2 - The Fairy Glade"), // Unknown frame size
        new(0x0801bff0, 0xc,  "Map 3 - The Fairy Glade"),
        new(0x0801c218, 0xc,  "Map 4 - The Precipice"),
        new(0x0801c440, 0xc,  "Map 5 - The Precipice"),
        new(0x0801c638, 0xc,  "Map 6 - The Echoing Caves"), // Unknown frame size
        new(0x0801c860, 0xc,  "Map 7 - The Echoing Caves"),
        new(0x0801ca88, 0xc,  "Map 8 - The Sanctuary of Rock and Lava"),
        new(0x0801ccb0, 0xc,  "Map 9 - The Sanctuary of Rock and Lava"),
        new(0x0801ccce, 0xc,  "Map 10 - Missile Race #1"), // Unknown frame size
    };

    public override int JoypadScanCallAddress => 0x0800023c;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x2c, 0xf0, 0xca, 0xfe };
}