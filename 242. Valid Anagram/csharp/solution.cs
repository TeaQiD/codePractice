public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!dict1.ContainsKey(c))
            {
                dict1[c] = 1;
            }
            else
            {
                dict1[c]++;
            }
        }
        foreach (char c in t)
        {
            if (!dict2.ContainsKey(c))
            {
                dict2[c] = 1;
            }
            else
            {
                dict2[c]++;
            }
        }
        if(dict1.Count != dict2.Count)
        {
            return false;
        }
        foreach(KeyValuePair<char, int> kvp in dict1)
        {
            if(!dict2.ContainsKey(kvp.Key) || dict2[kvp.Key] != kvp.Value)
            {
                return false;
            }
        }
        return true;
    }
}