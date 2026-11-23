// 101. Construct Quad Tree (Medium) - LeetCode #427
// https://leetcode.com/problems/construct-quad-tree/
// Run the tests: .\check.ps1 101
namespace NC101_ConstructQuadTree;

// Definition for a QuadTree node (provided, do not edit).
public class Node
{
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() { }

    public Node(bool _val, bool _isLeaf)
    {
        val = _val;
        isLeaf = _isLeaf;
    }

    public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
    {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}

public class Solution
{
    public Node Construct(int[][] grid)
    {
        throw new NotImplementedException();
    }
}
