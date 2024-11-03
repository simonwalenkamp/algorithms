namespace algorithms;

public class BubbleSort : Sorter
{
    public override int[] Sort(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            bool swapped = false;
            for (int j = 0; j < input.Length - i - 1; j++)
            {
                if (input.Length - i == j + 1) break;
                if (input[j] <= input[j + 1]) continue;

                Swap(input, j + 1, j);
                swapped = true;
            }
            if (!swapped) break;
        }

        return input;
    }
}
