public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sToT = new Dictionary<char, char>();
        var tToS = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char source = s[i];
            char target = t[i];

            if (sToT.TryGetValue(source, out char mappedTarget))
            {
                if (mappedTarget != target)
                {
                    return false;
                }
            }
            else
            {
                sToT[source] = target;
            }

            if (tToS.TryGetValue(target, out char mappedSource))
            {
                if (mappedSource != source)
                {
                    return false;
                }
            }
            else
            {
                tToS[target] = source;
            }
        }

        return true;
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();
        string s = "egg";
        string t = "add";
        Console.WriteLine(solution.IsIsomorphic(s, t));
    }
}