public class Solution {
    public int SingleNumber(int[] nums) {
        var n = 0;
        foreach (var i in nums) n ^= i;
        return n;
    }
}