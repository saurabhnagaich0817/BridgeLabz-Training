
public class Solution {
public bool IsHappy(int n) {
    HashSet<int> set=new();
    while(n!=1){
        if(set.Contains(n)) return false;
        set.Add(n);
        int sum=0;
        while(n>0){ sum+=(n%10)*(n%10); n/=10; }
        n=sum;
    }
    return true;
}
}
