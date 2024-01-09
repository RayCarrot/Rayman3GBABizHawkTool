namespace Rayman3GBABizHawkTool;

public class Rayman3_ECTS_20020809 : Game
{
    public override string Name => "Rayman 3 - ECTS (2002/08/09)";

    public override int MemoryManagerAddress => 0x03002240;

    public override int NextFrameAddress => 0x03002064;
    public override int NextFrameSizeAddress => 0x0300206a;
    public override Frame[] Frames => new Frame[]
    {
        new(0x08002b9c, 0x44, "Main Menu"),

        new(0x080850cc, 0x40, "Act #1"),
        new(0x0808516c, 0x40, "Act #2"), // Unknown frame size
        new(0x0808520c, 0x40, "Act #3"), // Unknown frame size
        new(0x08085368, 0x40, "Act #4"), // Unknown frame size

        new(0x0808083c, 0x3c, "Worldmap"),
        new(0x08081350, 0x48, "Worldmap - World 1"), // Unknown frame size
        new(0x08081620, 0x48, "Worldmap - World 2"), // Unknown frame size
        new(0x080818f0, 0x48, "Worldmap - World 3"),
        new(0x08081bc0, 0x48, "Worldmap - World 4"), // Unknown frame size
    };

    public override int JoypadScanCallAddress => 0x080001f0;
    public override byte[] JoypadScanCallOriginalBytes => new byte[] { 0x9a, 0xf0, 0xec, 0xfb };
}