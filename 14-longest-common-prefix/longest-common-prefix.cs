public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string prefix = "";
        string prefix1 = "";

        for (int i = 0; i < strs[0].Length; i++)
        {
            prefix = prefix + strs[0][i];

            int count = countPrefix(strs, prefix);

            if (count == 0)
            {
                break;
            }
            else
            {
                prefix1 = prefix;
            }
        }

        return prefix1;
    }

    public int countPrefix(string[] strs, string prefix)
    {
        int count = 0;

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].StartsWith(prefix))
            {
                count++;
            }
        }

        return count == strs.Length ? count : 0;
    }
}