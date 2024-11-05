using System;

namespace algorithms;

public class BinarySearch
{
    public int? Search(int[] input, int value)
    {
        return FindMiddle(input, value, 0, input.Length - 1);
    }

    public int? FindMiddle(int[] input, int value, int start, int end)
    {
        if (start > end)
            return null;

        int middle = (start + end) / 2;

        if (input[middle] == value)
            return middle;
        else if (input[middle] > value)
            return FindMiddle(input, value, start, middle - 1);
        else
            return FindMiddle(input, value, middle + 1, end);
    }
}