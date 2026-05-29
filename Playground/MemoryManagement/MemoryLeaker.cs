

namespace Playground.MemoryManagement;

public class MemoryLeaker
{
    private static readonly List<byte[]> _leakCache = new List<byte[]>();
    public static void Run()
    {
        WriteLine("Press any key to start leaking");
        WriteLine();
        ReadKey();
        int iteration = 0;

        while (true)
        {
            //10 * 1024 * 1024 == 10MB

            //allocate 10MB per iteration and keep reference forever
            byte[] chunk = new byte[10 * 1024 * 1024];
            for (int i = 0; i < chunk.Length; i += 1000)
                chunk[i] = (byte)(iteration % 256);

            _leakCache.Add(chunk); // this will keep the byte arrays in memory. GC wont clean it up

            iteration++;
            WriteLine($"Iteration {iteration} - leaked {iteration * 10} MB so far....");
            WriteLine();


            //let it run enough to see memory grow in task manager
            if (iteration % 10 == 0)
                ReadKey();  // pause iteration so we can observe


        }
    }
}
