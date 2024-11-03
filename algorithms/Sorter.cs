namespace algorithms;

public abstract class Sorter
{
    public abstract int[] Sort(int[] input);

    public static void Swap(int[] input, int swapIndex1, int swapIndex2)
    {
        int temp1 = input[swapIndex1];
        int temp2 = input[swapIndex2];
        input[swapIndex1] = temp2;
        input[swapIndex2] = temp1;
    }
}
