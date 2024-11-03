namespace algorithms;

public class InsertionSort : Sorter
{
    public override int[] Sort(int[] input)
    {
        for (int i = 1; i < input.Length; i++)
        {
            int j = i;
            while (j > 0 && input[j - 1] > input[j])
            {
                Swap(input, j, j - 1);
                j--;
            }
        }

        return input;
    }
}
