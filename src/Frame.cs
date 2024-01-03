namespace Rayman3GBABizHawkTool;

public class Frame
{
    public Frame(int constructorAddress, byte? classSize, string name)
    {
        ConstructorAddress = constructorAddress;
        ClassSize = classSize ?? 0x20; // If unknown, default to 32 which should be big enough
        Name = name;
    }

    public int ConstructorAddress { get; set; }
    public byte ClassSize { get; set; }
    public string Name { get; }
}