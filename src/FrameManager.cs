using BizHawk.Client.Common;

namespace Rayman3GBABizHawkTool;

// A "frame" in the Ubisoft GBA engine is basically the equivalent of a "scene" in modern engines. Each
// level is a frame. Each cutscene is a frame. Credits is a frame, menu is a frame and so on. This class
// allows us to switch the current frame in the game.
// This is done by injecting a custom function at the ROM header which allocates the frame and sets it
// to be the next one to initialize. We replace the call to scan the joypad with this for one game-frame.
public static class FrameManager
{
    private const int CustomFunctionAddr = 0x08000004;

    // Create ARM7 bl instruction
    private static byte[] CreateFunctionCallInstruction(int instructionAddress, int functionAddress)
    {
        // Create bl instruction/function call to class constructor
        ushort v0 = 0xF000;
        ushort v1 = 0xF800;

        int offset = (functionAddress - (instructionAddress + 4)) >> 1;

        v0 = (ushort)BitHelpers.SetBits(v0, BitHelpers.ExtractBits(offset, 11, 11), 11, 0);
        v1 = (ushort)BitHelpers.SetBits(v1, BitHelpers.ExtractBits(offset, 11, 0), 11, 0);

        return new[] { (byte)v0, (byte)(v0 >> 8), (byte)v1, (byte)(v1 >> 8) };
    }

    public static void InjectCustomFunction(IMemoryApi mem, Game game, Frame frame)
    {
        byte[] frameConstructorCall = CreateFunctionCallInstruction(CustomFunctionAddr + 14, frame.ConstructorAddress);
        
        byte[] func =
        {
            0x10, 0xb5,            // push    {r4, lr}
            0x08, 0x49,            // ldr     r1, [pc, #0x20]
            0x0c, 0x68,            // ldr     r4, [r1, #0]
            0x20, 0x1c,            // adds    r0, r4, #0
            frame.ClassSize, 0x30, // adds    r0, #(frame.ClassSize)
            0x08, 0x60,            // str     r0, [r1, #0]
            0x20, 0x1c,            // adds    r0, r4, #0
            frameConstructorCall[0], frameConstructorCall[1], frameConstructorCall[2], frameConstructorCall[3],
            0x05, 0x48,            // ldr     r0, [pc, #0x14]
            0x04, 0x60,            // str     r4, [r0, #0]
            0x05, 0x49,            // ldr     r1, [pc, #0x14]
            frame.ClassSize, 0x20, // movs    r0, #(frame.ClassSize)
            0x08, 0x80,            // strh    r0, [r1, #0]
            0x10, 0xbc,            // pop     {r4}
            0x01, 0xbc,            // pop     {r0}
            0x00, 0x47,            // bx      r0
            0x00, 0x00,            // Padding
        };
        mem.WriteByteRange(CustomFunctionAddr, func);

        // Write data used by the code
        mem.WriteS32(CustomFunctionAddr + func.Length + 0, game.MemoryManagerAddress + 0); // internalPool.pNextFree
        mem.WriteS32(CustomFunctionAddr + func.Length + 4, game.FrameMngrAddress + 4);     // nextFrame
        mem.WriteS32(CustomFunctionAddr + func.Length + 8, game.FrameMngrAddress + 10);    // nextFrameSize
    }

    public static void EnableCustomFunction(IMemoryApi mem, Game game)
    {
        mem.WriteByteRange(game.JoypadScanCallAddress, CreateFunctionCallInstruction(game.JoypadScanCallAddress, CustomFunctionAddr));
    }

    public static void DisableCustomFunction(IMemoryApi mem, Game game)
    {
        mem.WriteByteRange(game.JoypadScanCallAddress, game.JoypadScanCallOriginalBytes);
    }
}