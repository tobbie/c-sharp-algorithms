using Playground.MemoryManagement;

namespace ProgramEntryPoint;

public class Program
{
    public static void Main(string[] args)
    {
        //ConvertTextToBytes.Run();
        // MemoryLeaker.Run();
        NonMemoryLeaker.Run();
    }
}
