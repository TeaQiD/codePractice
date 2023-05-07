public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> list = new List<int>();
        foreach (int item in nums)
        {
            if (list.Contains(item))
            {
                return true;
            }
            else
            {
                list.Add(item);
            }
        }
        return false;
    }
}