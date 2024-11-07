using BenchmarkDotNet.Attributes;

namespace Crank_BenchmarkDotnet;

public class QueueBenchmarks
{
	[Params(10, 100, 1000, 10000)]

	public int ArraySize { get; set; }

	[Benchmark(Baseline = true)]
	public void First_Benchmark()
	{
		for (var i = 0; i < ArraySize; i++)
		{
			Guid.NewGuid();
		}
	}

	[Benchmark]
	public void Second_Benchmark()
	{
		for (var i = 0; i < ArraySize; i++)
		{
			Guid.Parse(Guid.NewGuid().ToString());
		}
	}
}
