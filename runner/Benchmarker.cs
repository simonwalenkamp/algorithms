using algorithms;
using BenchmarkDotNet.Attributes;

namespace runner;

public class Benchmarker
{
    private int[] GenerateInput()
    {
        Random random = new();
        return Enumerable
            .Repeat(0, 1_000)
            .Select(i => random.Next())
            .ToArray();
    }

    [Benchmark]
    public void RunBubbleSort()
    {
        int[] input = GenerateInput();

        BubbleSort bubbleSort = new();

        bubbleSort.Sort(input);
    }

    [Benchmark]
    public void RunInsertionSort()
    {
        int[] input = GenerateInput();

        InsertionSort insertionSort = new();

        insertionSort.Sort(input);
    }

    [Benchmark]
    public void RunMySort()
    {
        int[] input = GenerateInput();

        MySort mySort = new();

        mySort.Sort(input);
    }

    [Benchmark]
    public void RunQuickSort()
    {
        int[] input = GenerateInput();

        QuickSort quickSort = new();

        quickSort.Sort(input);
    }
}
