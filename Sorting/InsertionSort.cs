namespace Codewars.Sorting;

public class InsertionSort
{
    public int[] Sort(int[] nums)
    {
        int length = nums.Length;
        for (int i = 1; i < length; i++)
        {
            int key = nums[i];
            int j = i - 1;
            while (j >= 0 && nums[j] > key)
            {
                nums[j + 1] = nums[j];
                j--;
            }

            nums[j + 1] = key;
        }

        return nums;
    }
}