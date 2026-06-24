public class Solution {
    public int SecondHighest(string s) {
        
        int max = -1;
        int secondMax = -1;

        foreach (char c in s)
        {
            if (c >= '0' && c <= '9')
            {
                int digit = c - '0';

                if (digit > max)
                {
                    secondMax = max;
                    max = digit;
                }
                else if (digit < max && digit > secondMax)
                {
                    secondMax = digit;
                }
            }
        }

        return secondMax;

    }
}