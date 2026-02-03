public class Solution {
public bool ContainsDuplicate(int[] nums) { 
    HashSet<int> set = new();
    foreach(int n in nums)
        if(!set.Add(n)) return true;
    return false;
}
}   