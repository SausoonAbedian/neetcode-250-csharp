// 1299. Replace Elements with Greatest Element on Right Side (Easy)
// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
// Run the tests: .\check.ps1 1299
namespace LC1299_ReplaceElements;

public class Solution
{
    // Replace every element in arr with the greatest element among
    // the elements to its right, and replace the last element with -1.
    // Return the array.
    public int[] ReplaceElements(int[] arr)
    {
        var max = -1;

        for (var i = arr.Length - 1; i >= 0; i--)
        {
            var original = arr[i];
            arr[i] = max;
            max = Math.Max(max, original);
        }
        
        return arr;
    }
}
