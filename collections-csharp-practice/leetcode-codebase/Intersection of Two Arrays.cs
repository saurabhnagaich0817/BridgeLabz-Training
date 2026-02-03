
   public class Solution {
   public int[] Intersection(int[] a, int[] b) {
    HashSet<int> s1=new(a), res=new();
    foreach(int x in b) if(s1.Contains(x)) res.Add(x);
    return res.ToArray();
}
   }