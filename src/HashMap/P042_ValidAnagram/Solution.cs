public class Solution
{
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sDic = new Dictionary<char, int>();
        var tDic = new Dictionary<char, int>();

        foreach(char c in s){
            if(sDic.TryGetValue(c, out int charCount)){
                sDic[c]++;
            }else{
                sDic[c] = 1;
            }
        }

        foreach(char c in t){
            if(tDic.TryGetValue(c, out int charCount)){
                tDic[c]++;
            }else{
                tDic[c] = 1;
            }
        }

        foreach(char c in s){
            if(tDic.TryGetValue(c, out int charCount)){
                if(sDic[c] != charCount){
                    return false;
                }
            }else{
                return false;
            }

        }

        return true;
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();
        string s = "anagram";
        string t = "nagaram";
        Console.WriteLine(solution.IsAnagram(s, t));

        s = "rat";
        t = "car";
        Console.WriteLine(solution.IsAnagram(s, t));
    }
}