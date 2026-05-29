using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Playground.MemoryManagement;

public class NonMemoryLeaker
{
    private static readonly List<byte[]> _leakCache = new List<byte[]>();
    public static void Run()
    {
        var services = new ServiceCollection();
        services.AddMemoryCache(options =>
        {
            options.SizeLimit = 100 * 1024 * 1024; //100MB limit to trigger eviction;
            options.CompactionPercentage = .20; // evict 20% when limit is exceeded
        });


        var provider = services.BuildServiceProvider();
        var cache = provider.GetRequiredService<IMemoryCache>();

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

            var entryOptions = new MemoryCacheEntryOptions
            {
                Size = chunk.Length,
                SlidingExpiration = TimeSpan.FromMinutes(15), //keep alive for 15mins if its access
                AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1) // remove if it's not accessed in 1hr

            };

            var key = $"leak_{iteration}";
            cache.Set(key, chunk, entryOptions);

            iteration++;
            WriteLine($"Iteration {iteration} - leaked {iteration * 10} MB so far....");
            WriteLine();


            //let it run enough to see memory grow in task manager
            if (iteration % 10 == 0)
                ReadKey();  // pause iteration so we can observe


        }
    }
}
