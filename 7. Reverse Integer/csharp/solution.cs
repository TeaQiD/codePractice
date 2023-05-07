public class Solution {
    public int Reverse(int x) {
        int ans = 0;
        int ten = 10;
        int reminder = 0;
        while (x != 0) {
            Console.WriteLine("x: " + x);
            reminder = x % ten;
            Console.WriteLine("Reminder: " + reminder);
            x = x / ten;
            Console.WriteLine("x2: " + x);
            if (ans > Int32.MaxValue / 10 || (ans == Int32.MaxValue / 10 && reminder > 7))
            {
                // Multiplying ans by 10 will cause an overflow
                return 0;
            }
            if (ans < Int32.MinValue / 10 || (ans == Int32.MinValue / 10 && reminder < -8))
            {
                // Multiplying ans by 10 will cause an underflow
                return 0;
            }
            ans = ans * 10 + reminder;
            Console.WriteLine("ans: " + ans);
        }
        return ans;
    }
}