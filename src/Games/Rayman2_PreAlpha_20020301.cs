namespace Rayman3GBABizHawkTool;

public class Rayman2_PreAlpha_20020301 : Game
{
    public override string Name => "Rayman 2 - Pre-Alpha (2002/03/01)";

    public override int MemoryManagerAddress => 0x03002994;

    public override int NextFrameAddress => 0x03002864;
    public override int NextFrameSizeAddress => 0x03002874;
    public override Frame[] Frames => new Frame[]
    {
        new(0x08000280, 0xc, "Title Screen"),
        new(0x080108d2, 0xc, "Slides"), // Unknown frame size

        new(0x0801037c, 0x8, "Map 0 - The Woods of Light"),
        new(0x080103d4, 0x8, "Map 1 - The Woods of Light"),
        new(0x080104f8, 0x8, "Map 2 - The Fairy Glade"), // Unknown frame size
        new(0x08010550, 0x8, "Map 3 - The Fairy Glade"),
        new(0x080105a8, 0x8, "Map 4 - The Precipice"),
        new(0x080105d2, 0x8, "Map 5 - The Precipice"), // Unknown frame size
        new(0x0801062c, 0x8, "Map 6 - The Echoing Caves"),
        new(0x08010684, 0x8, "Map 7 - The Echoing Caves"),
        new(0x080106dc, 0x8, "Map 8 - The Sanctuary of Rock and Lava"),
        new(0x08010734, 0x8, "Map 9 - The Sanctuary of Rock and Lava"),
    };

    public override int JoypadScanCallAddress => 0x0800023a;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x20, 0xf0, 0xd1, 0xf8 };
}