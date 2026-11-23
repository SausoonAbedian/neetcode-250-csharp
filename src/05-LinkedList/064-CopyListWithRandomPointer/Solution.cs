// 064. Copy List With Random Pointer (Medium) - LeetCode #138
// https://leetcode.com/problems/copy-list-with-random-pointer/
// Run the tests: .\check.ps1 64
namespace NC064_CopyListWithRandomPointer;

// Definition for a Node (provided, do not edit).
public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        throw new NotImplementedException();
    }
}
