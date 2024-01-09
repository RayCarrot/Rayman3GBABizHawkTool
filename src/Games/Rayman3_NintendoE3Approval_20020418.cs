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
        new(0x0800110c, 0x30, "GameCube Link"), // Unknown frame size

        // new(0x0800086c, 0x2c, "Old Main Menu"), // Unknown frame size - crashes
        // new(0x080009c0, 0x2c, "Old Multiplayer Menu"), // Unknown frame size - crashes

        new(0x0802d15c, 0x10, "Map 0 - The Woods of Light"),
        new(0x0802d550, 0x10, "Map 1 - The Woods of Light"),
        new(0x0802d91c, 0x10, "Map 2 - The Fairy Glade"),
        new(0x0802dd10, 0x14, "Map 3 - The Fairy Glade"), // Unknown frame size
        new(0x0802e6e8, 0x14, "Map 4 - The Echoing Caves"), // Unknown frame size
        new(0x0802e9e4, 0x10, "Map 5 - The Echoing Caves"),
        new(0x0802f598, 0x10, "Map 6 - Beneath the Sanctuary of Rock and Lava"),
        new(0x0802f5b0, 0x14, "Map 7 - Beneath the Sanctuary of Rock and Lava"), // Unknown frame size
        new(0x0802e0cc, 0x14, "Map 8 - The Precipice"),
        new(0x0802e3e0, 0x14, "Map 9 - The Precipice"), // Unknown frame size
        new(0x0802ecf0, 0x10, "Map 10 - The Sanctuary of Rock and Lava"),
        new(0x0802efb4, 0x14, "Map 11 - The Sanctuary of Rock and Lava"), // Unknown frame size
        // new(0x0802efde, 0x14, "Map 12 - Missile Race #1"), // Unknown frame size - doesn't load because of outdated tilekit format
    };

    public override int JoypadScanCallAddress => 0x08000284;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x42, 0xf0, 0x4e, 0xfa };
}