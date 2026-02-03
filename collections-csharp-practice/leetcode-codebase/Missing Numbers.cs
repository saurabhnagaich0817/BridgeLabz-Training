public IList<int> FindDisappearedNumbers(int[] nums) {
    HashSet<int> set=new(nums);
    List<int> res=new();
    for(int i=1;i<=nums.Length;i++)
        if(!set.Contains(i)) res.Add(i);
    return res;
}
