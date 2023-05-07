public class Solution {
    public int StrStr(string haystack, string needle) {
                if (needle.Length == 0 || needle.Length > haystack.Length)
        {
            return -1;
        }
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack.Length - i < needle.Length)
            {
                Console.WriteLine(haystack.Length);
                Console.WriteLine(haystack.Length - i);
                Console.WriteLine(needle.Length);
                return -1;
            }
            int g = i;
            for (int j = 0 ; j < needle.Length; j++)
            {
                Console.WriteLine(haystack[g] + " " + needle[j]);
                if ((haystack[g] == needle[j]))
                {
                    if(j == needle.Length -1) 
                    {
                        return i;
                    }
                    g++;
                }
                else
                {
                    Console.WriteLine("BREAK");
                    break;
                }
            }
        }
        return -1;
    }
}