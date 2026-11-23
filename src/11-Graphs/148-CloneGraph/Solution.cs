// 148. Clone Graph (Medium) - LeetCode #133
// https://leetcode.com/problems/clone-graph/
// Run the tests: .\check.ps1 148
namespace NC148_CloneGraph;

// Definition for a Node (provided, do not edit).
public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}

public class Solution
{
    public Node CloneGraph(Node node)
    {
        throw new NotImplementedException();
    }
}
