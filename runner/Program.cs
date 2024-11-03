// See https://aka.ms/new-console-template for more information
using algorithms;
using BenchmarkDotNet.Running;
using runner;

internal class Program
{
    private static void Main()
    {
        BenchmarkRunner.Run<Benchmarker>();
    }
}