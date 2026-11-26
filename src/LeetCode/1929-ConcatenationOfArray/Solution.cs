// 1929. Concatenation of Array (Easy)
// https://leetcode.com/problems/concatenation-of-array/
// Run the tests: .\check.ps1 1929
namespace LC1929_ConcatenationOfArray;

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        var res = new int[nums.Length * 2];

        for (var i = 0; i < nums.Length; i++)
        {
            res[i] = nums[i];
            res[i + nums.Length] = nums[i];
        }

        return res;
    }
}
