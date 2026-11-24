namespace LC0002_AddTwoNumbers;

/// <summary>Singly linked list node, same shape as LeetCode's C# definition.</summary>
public partial class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
