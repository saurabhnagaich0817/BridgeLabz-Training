public class Solution {
public int[] TopKFrequent(int[] nums, int k) {
    Dictionary<int,int> map=new();
    foreach(int n in nums) map[n]=map.GetValueOrDefault(n,0)+1;
    return map.OrderByDescending(x=>x.Value)
              .Take(k).Select(x=>x.Key).ToArray();
}
}
