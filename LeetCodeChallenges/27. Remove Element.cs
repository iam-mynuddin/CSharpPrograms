using Collections;

namespace LeetCodeChallenges
{
    public static class Problem27
    {
        public static void Run()
        {
            Console.WriteLine(Solution.RemoveElement([3, 2, 2, 3], 3));
        }

        public static class Solution
        {
            public static int RemoveElement(int[] nums, int val)
            {
                int result = 0;
                foreach (int item in nums)
                {
                    if(item != val )
                    {
                        nums[result]=item;
                        result = result + 1;
                    }
                }
                return result;
            }
        }
    }
}