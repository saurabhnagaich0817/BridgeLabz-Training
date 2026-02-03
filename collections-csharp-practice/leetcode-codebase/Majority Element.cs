
public class Solution {
public int MajorityElement(int[] nums) {
    Dictionary<int,int> map=new();
    foreach(int n in nums){
        map[n]=map.GetValueOrDefault(n,0)+1;
        if(map[n]>nums.Length/2) return n;
    }
    return -1;
}
}
