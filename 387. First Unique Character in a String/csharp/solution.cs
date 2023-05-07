public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> result = new Dictionary<char, int>();
        int index = 1;
        foreach (char c in s)
        {
            if (!result.ContainsKey(c))
            {
                result[c] = index;
            }
            else
            {
                result[c] = 0;
            }
            index++;
        }
        int ans = 0;
        foreach (KeyValuePair<char, int> kvp in result)
        {
            if (kvp.Value != 0)
            {
                ans = kvp.Value - 1;
                break;
            }
            else
            {
                ans = -1;
            }
        }
        // foreach (KeyValuePair<char, int> kvp in result)
        // {
        //     Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        // }
        return ans;
    }
}