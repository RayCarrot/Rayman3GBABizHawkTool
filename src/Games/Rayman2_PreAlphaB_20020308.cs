namespace Rayman3GBABizHawkTool;

public class Rayman2_PreAlphaB_20020308 : Game
{
    public override string Name => "Rayman 2 - Pre-Alpha (B) (2002/03/08)";

    public override int MemoryManagerAddress => 0x03002994;

    public override int NextFrameAddress => 0x03002864;
    public override int NextFrameSizeAddress => 0x0300286a;
    public override Frame[] Frames => new Frame[]
    {
        new(0x080154dc, 0x14, "Ubisoft Logo"),
        new(0x08000280, 0x10, "Title Screen"),

        new(0x08013ee0, 0xc,  "Map 0 - The Woods of Light"), // Unknown frame size
        new(0x08014140, 0xc,  "Map 1 - The Woods of Light"),
        new(0x080143fc, 0xc,  "Map 2 - The Fairy Glade"), // Unknown frame size
        new(0x08014624, 0xc,  "Map 3 - The Fairy Glade"),
        new(0x0801484c, 0xc,  "Map 4 - The Precipice"),
        new(0x08014a44, 0xc,  "Map 5 - The Precipice"), // Unknown frame size
        new(0x08014c6c, 0xc,  "Map 6 - The Echoing Caves"),
        new(0x08014e94, 0xc,  "Map 7 - The Echoing Caves"),
        new(0x080150bc, 0xc,  "Map 8 - The Sanctuary of Rock and Lava"),
        new(0x080152e4, 0xc,  "Map 9 - The Sanctuary of Rock and Lava"),
        new(0x08015304, 0xc,  "Map 10 - Missile Race #1"), // Unknown frame size
    };

    public override int JoypadScanCallAddress => 0x08000236;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x25, 0xf0, 0xa9, 0xf8 };
}