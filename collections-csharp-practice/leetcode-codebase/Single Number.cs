public int SingleNumber(int[] nums) {
    HashSet<int> set=new();
    foreach(int n in nums)
        if(!set.Add(n)) set.Remove(n);
    return set.First();
}
