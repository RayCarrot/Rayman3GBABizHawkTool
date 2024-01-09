namespace Rayman3GBABizHawkTool;

public class Rayman3_E3GameCube_20020513 : Game
{
    public override string Name => "Rayman 3 - E3 GameCube (2002/05/13)";

    public override int MemoryManagerAddress => 0x03002260;

    public override int NextFrameAddress => 0x030020a4;
    public override int NextFrameSizeAddress => 0x030020aa;
    public override Frame[] Frames => new Frame[]
    {
        new(0x08039cec, 0x18, "Ubisoft Logo"),
        new(0x08002878, 0x8,  "Title Screen"),
        new(0x08000820, 0x10, "Main Menu"),
        new(0x08000eec, 0x44, "GameCube Link"),

        new(0x080368c8, 0x10, "Map 0 - The Woods of Light"),
        new(0x08036ccc, 0x10, "Map 1 - The Woods of Light"),
        new(0x080370a8, 0x18, "Map 2 - The Fairy Glade"), // Unknown frame size
        // new(0x080374ac, 0x18, "Map 3 - The Fairy Glade"),  // Unknown frame size - crashes
        new(0x08038ed4, 0x10, "Map 4 - Sanctuary of the Big Trees"),
        new(0x08038ba0, 0xc,  "Map 5 - The Marshes of Awakening #1"),
        new(0x08037fe4, 0x18, "Map 6 - The Echoing Caves"), // Unknown frame size
        new(0x08038300, 0x10, "Map 7 - The Echoing Caves"),
        new(0x08039470, 0x10, "Map 8 - Beneath the Sanctuary of Rock and Lava"),
        new(0x08039488, 0x18, "Map 9 - Beneath the Sanctuary of Rock and Lava"), // Unknown frame size
        new(0x08037904, 0x18, "Map 10 - The Precipice"),
        new(0x08037d08, 0x18, "Map 11 - The Precipice"), // Unknown frame size
        new(0x08038620, 0x10, "Map 12 - The Sanctuary of Rock and Lava"),
        new(0x080388e4, 0x18, "Map 13 - The Sanctuary of Rock and Lava"), // Unknown frame size
        new(0x08039ac8, 0x18, "Map 14 - The Canopy"), // Unknown frame size
        new(0x08039ae0, 0x18, "Map 15 - The Canopy"), // Unknown frame size
    };

    public override int JoypadScanCallAddress => 0x08000288;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x4b, 0xf0, 0x1e, 0xf8 };
}