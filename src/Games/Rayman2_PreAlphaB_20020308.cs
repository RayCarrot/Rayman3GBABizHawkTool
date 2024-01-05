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
        new(0x08000280, 0x10, "Game Logo"),
        new(0x08013ee0, null, "Map 0 (Unused)"),
        new(0x08014140, 0xc,  "Map 1"),
        new(0x080143fc, null, "Map 2 (Unused)"),
        new(0x08014624, 0xc,  "Map 3 (Unused)"),
        new(0x0801484c, 0xc,  "Map 4"),
        new(0x08014a44, null, "Map 5 (Unused)"),
        new(0x08014c6c, 0xc,  "Map 6 (Unused)"),
        new(0x08014e94, 0xc,  "Map 7 (Unused)"),
        new(0x080150bc, 0xc,  "Map 8 (Unused)"),
        new(0x080152e4, 0xc,  "Map 9 (Unused)"),
        new(0x08015304, null, "Map 10 (Unused)"),
    };

    public override int JoypadScanCallAddress => 0x08000236;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x25, 0xf0, 0xa9, 0xf8 };
}