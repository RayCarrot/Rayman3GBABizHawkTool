namespace Rayman3GBABizHawkTool;

public abstract class Game
{
    public abstract string Name { get; }

    public abstract int MemoryManagerAddress { get; }

    public abstract int FrameMngrAddress { get; }
    public abstract Frame[] Frames { get; }

    public abstract int JoypadScanCallAddress { get; }
    public abstract byte[] JoypadScanCallOriginalBytes { get; }
}