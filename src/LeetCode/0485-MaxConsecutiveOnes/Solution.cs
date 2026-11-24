// 485. Max Consecutive Ones (Easy)
// https://leetcode.com/problems/max-consecutive-ones/
// Run the tests: .\check.ps1 485
namespace LC0485_MaxConsecutiveOnes;

public class Solution
{
    // Given a binary array nums, return the maximum number
    // of consecutive 1's in the array.
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var max = 0;
        var count = 0;
        
        foreach (var num in nums)
        {
            if (num == 1)
                max = Math.Max(max, ++count);
            else
                count = 0;
        }

        return max;
    }
}
