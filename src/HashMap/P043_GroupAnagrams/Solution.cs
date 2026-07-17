public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, IList<string>>();

        foreach(string str in strs){
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new string(charArray);

            if(dic.TryGetValue(sortedStr, out IList<string> anagrams)){
                anagrams.Add(str);
            }else{
                dic[sortedStr] = new List<string>(){str};
            }
        }

        return dic.Values.ToList();
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();
        string[] strs = new string[]{"eat","tea","tan","ate","nat","bat"};
        var result = solution.GroupAnagrams(strs);
        foreach(var group in result){
            Console.WriteLine(string.Join(", ", group));
        }
    }
}