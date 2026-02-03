public int LengthOfLongestSubstring(string s) {
    HashSet<char> set=new();
    int l=0,max=0;
    for(int r=0;r<s.Length;r++){
        while(set.Contains(s[r])) set.Remove(s[l++]);
        set.Add(s[r]);
        max=Math.Max(max,r-l+1);
    }
    return max;
}
