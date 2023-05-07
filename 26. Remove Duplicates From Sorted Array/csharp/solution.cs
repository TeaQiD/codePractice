public class Solution {
    public int RemoveDuplicates(int[] nums) {
       int k = 1;
        int prev = nums[0];
        for (int i = 1; i < nums.Count(); i++)
        {
            if (prev != nums[i])
            {
                nums[k] = nums[i];
                k++;
            }
            prev = nums[i];
        }
        return k;
    }
}