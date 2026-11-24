namespace LC0199_BinaryTreeRightSideView;

/// <summary>Binary tree node, same shape as LeetCode's C# definition.</summary>
public partial class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
