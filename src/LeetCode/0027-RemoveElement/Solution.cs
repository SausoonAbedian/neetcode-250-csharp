// 27. Remove Element (Easy)
// https://leetcode.com/problems/remove-element/
// Run the tests: .\check.ps1 27
namespace LC0027_RemoveElement;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var k = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            nums[k] = nums[i];
            if (nums[i] != val)
                k++;
        }

        return k;
    }
}
