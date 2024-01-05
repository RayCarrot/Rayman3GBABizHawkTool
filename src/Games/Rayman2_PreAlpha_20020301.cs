namespace Rayman3GBABizHawkTool;

public class Rayman2_PreAlpha_20020301 : Game
{
    public override string Name => "Rayman 2 - Pre-Alpha (2002/03/01)";

    public override int MemoryManagerAddress => 0x03002994;

    public override int NextFrameAddress => 0x03002864;
    public override int NextFrameSizeAddress => 0x03002874;
    public override Frame[] Frames => new Frame[]
    {
        new(0x08000280, 0xc,  "Game Logo"),
        new(0x080108d2, null, "Slides (Unused)"),
        new(0x0801037c, 0x8,  "Map 0 (Unused)"),
        new(0x080103d4, 0x8,  "Map 1"),
        new(0x080104f8, null, "Map 2 (Unused)"),
        new(0x08010550, 0x8,  "Map 3 (Unused)"),
        new(0x080105a8, 0x8,  "Map 4"),
        new(0x080105d2, null, "Map 5 (Unused)"),
        new(0x0801062c, 0x8,  "Map 6 (Unused)"),
        new(0x08010684, 0x8,  "Map 7 (Unused)"),
        new(0x080106dc, 0x8,  "Map 8 (Unused)"),
        new(0x08010734, 0x8,  "Map 9 (Unused)"),
    };

    public override int JoypadScanCallAddress => 0x0800023a;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x20, 0xf0, 0xd1, 0xf8 };
}