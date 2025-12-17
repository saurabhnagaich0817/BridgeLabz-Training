public class LeetCodeSolutions{

    // 1. Two Sum
    public static int[] twoSum(int[] nums, int target){
        for(int i =0; i< nums.length; i++){
            for(int j =i + 1; j< nums.length; j++){
                if(nums[i] + nums[j] ==target){
                    return new int[]{i, j};
                }
            }
        }
        return new int[]{};
    }

    // 2. Reverse Integer
    public static int reverse(int x){
        int rev =0;
        while(x !=0){
            int digit =x % 10;
            rev =rev * 10 + digit;
            x /=10;
        }
        return rev;
    }

    // 3. Palindrome Number
    public static boolean isPalindrome(int x){
        int original =x, rev =0;
        while(x > 0){
            rev =rev * 10 + x % 10;
            x /=10;
        }
        return original ==rev;
    }

    // 4. Fibonacci Number
    public static int fib(int n){
        if(n<=1) return n;
        int a =0, b =1;
        for(int i =2; i<=n; i++){
            int c =a + b;
            a =b;
            b =c;
        }
        return b;
    }

    // 5. Factorial
    public static int factorial(int n){
        int fact =1;
        for(int i =1; i<=n; i++){
            fact *=i;
        }
        return fact;
    }
}
