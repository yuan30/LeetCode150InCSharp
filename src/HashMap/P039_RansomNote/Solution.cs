public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineCharCount = new Dictionary<char, int>();

        foreach (var c in magazine)
        {
            if (!magazineCharCount.ContainsKey(c))
            {
                magazineCharCount[c] = 0;
            }
            magazineCharCount[c]++;
        }

        foreach (var c in ransomNote)
        {
            if (!magazineCharCount.ContainsKey(c) || magazineCharCount[c] == 0)
            {
                return false;
            }
            magazineCharCount[c]--;
        }

        return true;
    }
}