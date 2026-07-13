public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var word = s.Split(' ');
        if (pattern.Length != word.Length)
        {
            return false;
        }

        var patternToWord = new Dictionary<char, string>();
        var wordToPattern = new Dictionary<string, char>();

        for(int i=0; i<pattern.Length; i++)
        {
            var p = pattern[i];
            var w = word[i];

            if (patternToWord.TryGetValue(p, out string mappedWord))
            {
                if(w != mappedWord)
                {
                    return false;
                }
            }
            else
            {
                patternToWord[p] = w;    
            }
            

            if(wordToPattern.TryGetValue(w, out char mappedPattern))
            {
                if(p != mappedPattern)
                {
                    return false;
                }
            }
            else
            {
                wordToPattern[w] = p;
            }

        }
        return true;
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();
        string pattern = "abba";
        string s = "dog cat cat dog";
        Console.WriteLine(solution.WordPattern(pattern, s));

        pattern = "aaaa";
        s = "dog cat cat dog";
        Console.WriteLine(solution.WordPattern(pattern, s));

        pattern = "baab";
        s = "dog cat cat dog";
        Console.WriteLine(solution.WordPattern(pattern, s));
    }
}