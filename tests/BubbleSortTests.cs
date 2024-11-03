using algorithms;

namespace tests;

public class BubbleSortTests
{
    [Fact]
    public void Sort()
    {
        BubbleSort sut = new();

        int[] input = [5, 4, 1, 9, 8, 2, 3, 7, 6];

        int[] result = sut.Sort(input);

        Assert.Equal([1, 2, 3, 4, 5, 6, 7, 8, 9], result);
    }
}