public IList<IList<string>> GroupAnagrams(string[] strs) {
    Dictionary<string,List<string>> map=new();
    foreach(string s in strs){
        char[] c=s.ToCharArray();
        Array.Sort(c);
        string key=new(c);
        if(!map.ContainsKey(key)) map[key]=new();
        map[key].Add(s);
    }
    return map.Values.ToList<IList<string>>();
}
