namespace algorithms;

public class MySort : Sorter
{
    public override int[] Sort(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            int currentLowestValueIndex = i;

            for (int j = i; j < input.Length; j++)
            {
                if (input[currentLowestValueIndex] > input[j])
                {
                    currentLowestValueIndex = j;
                }

                if (j == input.Length - 1)
                {
                    Swap(input, i, currentLowestValueIndex);
                }
            }
        }

        return input;
    }
}
