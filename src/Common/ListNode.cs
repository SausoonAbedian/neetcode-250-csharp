namespace DSA.Common;

/// <summary>Singly linked list node, same shape as LeetCode's C# definition.</summary>
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    /// <summary>Builds a list from values. Returns null for an empty array.</summary>
    public static ListNode From(params int[] values)
    {
        var dummy = new ListNode();
        var cur = dummy;
        foreach (var v in values)
        {
            cur.next = new ListNode(v);
            cur = cur.next;
        }
        return dummy.next;
    }

    /// <summary>Converts a list back to an array (guards against cycles).</summary>
    public static int[] ToArray(ListNode head)
    {
        var result = new List<int>();
        var guard = 0;
        while (head != null)
        {
            if (++guard > 100_000) throw new InvalidOperationException("List looks cyclic.");
            result.Add(head.val);
            head = head.next;
        }
        return result.ToArray();
    }

    public override string ToString() => "[" + string.Join(",", ToArray(this)) + "]";
}
