namespace algorithms;

public class QuickSort : Sorter
{
    public override int[] Sort(int[] input)
    {
        Quick(input, 0, input.Length - 1);
        return input;
    }

    public void Quick(int[] input, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = input[left];

        while (i <= j)
        {
            while (input[i] < pivot)
            {
                i++;
            }

            while (input[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                Swap(input, i, j);
                i++;
                j--;
            }
        }

        if (left < j)
            Quick(input, left, j);

        if (i < right)
            Quick(input, i, right);
    }
}
