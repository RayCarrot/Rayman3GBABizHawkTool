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

        new(0x0803957c, 0x20, "Map 0 - The Woods of Light"),
        new(0x08039980, 0x20, "Map 1 - The Woods of Light"),
        new(0x08039d5c, 0x24, "Map 2 - The Fairy Glade"), // Unknown frame size
        // new(0x0803a160, 0x24, "Map 3 - The Fairy Glade"), // Unknown frame size - crashes
        new(0x0803c04c, 0x20, "Map 4 - Sanctuary of the Big Trees"),
        new(0x0803bd0c, 0xc,  "Map 5 - The Marshes of Awakening #1"),
        new(0x0803ae20, 0x24, "Map 6 - The Echoing Caves"), // Unknown frame size
        new(0x0803b4a8, 0x24, "Map 7 - The Echoing Caves"),
        new(0x0803c620, 0x20, "Map 8 - Beneath the Sanctuary of Rock and Lava"),
        new(0x0803c638, 0x24, "Map 9 - Beneath the Sanctuary of Rock and Lava"), // Unknown frame size
        new(0x0803a5cc, 0x28, "Map 10 - The Precipice"),
        new(0x0803ab50, 0x24, "Map 11 - The Precipice"), // Unknown frame size
        new(0x0803b784, 0x20, "Map 12 - The Sanctuary of Rock and Lava"),
        // new(0x0803ba48, 0x24, "Map 13 - The Sanctuary of Rock and Lava"), // Unknown frame size - crashes
        new(0x0803cc6c, 0x24, "Map 14 - The Canopy"), // Unknown frame size
        new(0x0803cc84, 0x20, "Map 15 - The Canopy"),
    };

    public override int JoypadScanCallAddress => 0x08000288;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x4d, 0xf0, 0xd2, 0xfe };
}