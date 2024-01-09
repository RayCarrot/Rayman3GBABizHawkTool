namespace Rayman3GBABizHawkTool;

public class Rayman3_LaRonde_20020719 : Game
{
    public override string Name => "Rayman 3 - La Ronde (2002/07/19)";

    public override int MemoryManagerAddress => 0x03002230;

    public override int NextFrameAddress => 0x03002054;
    public override int NextFrameSizeAddress => 0x0300205a;
    public override Frame[] Frames => new Frame[]
    {
        new(0x0806ebc0, 0x3c, "Worldmap (maps 0-42)"), // You can access the first 43 maps from here
        new(0x08074140, 0x20, "Map 43 - The Sanctuary of Rock and Lava"),
        new(0x0807a52c, 0x20, "Map 44 - The Sanctuary of Stone and Fire"),
        // Map 45-53 are multiplayer and can be accessed normally
    };

    public override int JoypadScanCallAddress => 0x080001f0;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x93, 0xf0, 0xc6, 0xfc };
}