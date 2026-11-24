// 1095. Find in Mountain Array (Hard)
// https://leetcode.com/problems/find-in-mountain-array/
// Run the tests: .\check.ps1 1095
namespace LC1095_FindInMountainArray;

/**
 * This is MountainArray's API interface (provided below, do not edit).
 * You should not implement it, or speculate about its implementation.
 * At most 100 calls to get() are allowed.
 */
public class Solution
{
    public int FindInMountainArray(int target, MountainArray mountainArr)
    {
        throw new NotImplementedException();
    }
}

// ---- provided ----
public class MountainArray
{
    private readonly int[] _a;
    public int GetCalls { get; private set; }
    public MountainArray(params int[] a) => _a = a;

    public int Get(int index)
    {
        if (++GetCalls > 100) throw new InvalidOperationException("More than 100 calls to Get().");
        return _a[index];
    }

    public int Length() => _a.Length;
}
