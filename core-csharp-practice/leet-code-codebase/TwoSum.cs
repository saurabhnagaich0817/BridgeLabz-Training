class TwoSum
{
  static void Main(string[] args)
  {
      int[] numbers ={ 2, 7, 11, 15 };
      int target =9;
      int[] result =FindTwoSum(numbers, target);

      if(result !=null)
      {
          Console.WriteLine("Indices found: " + result[0] + ","+result[1]);
      }
      else
      {
          Console.WriteLine("No two sum solution found.");
      }
  }

  static int[] FindTwoSum(int[] nums, int target)
  {
      for(int i =0; i < nums.Length; i++)
      {
          for(int j =i + 1; j < nums.Length; j++)
          {
              if(nums[i] + nums[j] ==target)
              {
                  return new int[] { i, j };
              }
          }
      }
      return null;
  }
}
