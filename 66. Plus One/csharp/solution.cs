public class Solution {
    public int[] PlusOne(int[] digits) {
        int[] result = digits;
        int least = result.Length - 1;
        for (int i = least; i >= 0; i--)
        {
            if (result[i] == 9)
            {
                result[i] = 0;
                if (i == 0)
                {
                    int[] newArray = new int[result.Length];
                    Array.Copy(result, newArray, result.Length);
                    result = new int[newArray.Length + 1];
                    result[0] = 1;
                    Array.Copy(newArray, 0, result, 1, newArray.Length);
                }
            }
            else
            {
                result[i]++;
                break;
            }
        }
        return result;
    }
}