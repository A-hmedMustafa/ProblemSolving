namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        return new int[] { i, j };
                    }
                    else
                    {
                        return new int[0];
                    }
                }


            }
            return new int[0];
        }
    }
}
