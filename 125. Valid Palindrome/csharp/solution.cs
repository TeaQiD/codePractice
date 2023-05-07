public class Solution {
    public bool IsPalindrome(string s) {
         string temp = new string(s.Where(c => Char.IsLetterOrDigit(c)).ToArray());
        temp = temp.ToLower();
        for (int i = 0; i < temp.Length/2; i++)
        {
            if (temp[i] != temp[temp.Length - 1 - i]) 
            {
                return false;
            }
        }
        return true;
    }
}