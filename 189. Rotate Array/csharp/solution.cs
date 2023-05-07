public class Solution {
    public void Rotate(int[] nums, int k) {
        List<int> list = nums.ToList();
        int index = 0;
        while (index < k)
        {
            int lastElement = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, lastElement);
            index++;
        }
        
        for (int i = 0; i < nums.Count(); i++) 
        {
            nums[i] = list[i];
        }
    }
}