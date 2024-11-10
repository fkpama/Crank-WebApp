using BenchmarkDotNet.Attributes;

namespace Crank_BenchmarkDotnet;

[MemoryDiagnoser]
[ThreadingDiagnoser]
[ExceptionDiagnoser]
public class QueueBenchmarks
{
	[Params(10, 100, 1000, 10000)]
	public int ArraySize { get; set; }

	[Params("Hello", "World")]
	public string? Text { get; set; }

	[Benchmark(Baseline = true, Description = "Some Description for First_Benchmark")]
	public void First_Benchmark()
	{
		for (var i = 0; i < ArraySize; i++)
		{
			Guid.NewGuid();
		}
	}

	[Benchmark(Description = "Some Description for Second_Benchmark")]
	public void Second_Benchmark()
	{
		for (var i = 0; i < ArraySize; i++)
		{
			Guid.Parse(Guid.NewGuid().ToString());
		}
	}

	public void Third_Benchmark()
	{
		throw new Exception();
	}
}
