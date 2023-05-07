public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        strs = strs.OrderBy(s => s.Length).ToArray();
        string prefix = strs[0];
        foreach (string str in strs)
        {
            for (int i = 0; i < prefix.Length; i++)
            {
                if ( i >= str.Length)
                {
                    prefix = prefix.Remove(i, prefix.Length - i);
                    break;
                }
                else if (prefix[i] != str[i])
                {
                    prefix = prefix.Remove(i, prefix.Length - i);
                    break;
                }
            }
        }
        return prefix;
    }
}