namespace StaticArrays;

public class StaticArrayTests
{
    private readonly StaticArray _sa = new();

    // ---------- InsertEnd ----------
    [Fact]
    public void InsertEnd_AddsAfterLastRealValue()
    {
        var arr = new[] { 1, 2, 3, 0, 0 };
        _sa.InsertEnd(arr, 9, length: 3, capacity: 5);
        Assert.Equal(new[] { 1, 2, 3, 9, 0 }, arr);
    }

    [Fact]
    public void InsertEnd_EmptyArray_GoesToIndexZero()
    {
        var arr = new int[3];
        _sa.InsertEnd(arr, 4, length: 0, capacity: 3);
        Assert.Equal(new[] { 4, 0, 0 }, arr);
    }

    [Fact]
    public void InsertEnd_FillsLastSlot()
    {
        var arr = new[] { 1, 2, 0 };
        _sa.InsertEnd(arr, 7, length: 2, capacity: 3);
        Assert.Equal(new[] { 1, 2, 7 }, arr);
    }

    [Fact]
    public void InsertEnd_FullArray_DoesNothing()
    {
        var arr = new[] { 1, 2, 3 };
        _sa.InsertEnd(arr, 9, length: 3, capacity: 3);
        Assert.Equal(new[] { 1, 2, 3 }, arr);
    }

    // ---------- RemoveEnd ----------
    [Fact]
    public void RemoveEnd_ClearsLastRealValue()
    {
        var arr = new[] { 1, 2, 3, 0 };
        _sa.RemoveEnd(arr, length: 3);
        Assert.Equal(new[] { 1, 2, 0, 0 }, arr);
    }

    [Fact]
    public void RemoveEnd_SingleElement()
    {
        var arr = new[] { 5 };
        _sa.RemoveEnd(arr, length: 1);
        Assert.Equal(new[] { 0 }, arr);
    }

    [Fact]
    public void RemoveEnd_EmptyArray_DoesNothing()
    {
        var arr = new[] { 0, 0, 0 };
        _sa.RemoveEnd(arr, length: 0); // must not throw
        Assert.Equal(new[] { 0, 0, 0 }, arr);
    }

    // ---------- InsertMiddle ----------
    [Fact]
    public void InsertMiddle_ShiftsRightAndInserts()
    {
        var arr = new[] { 1, 2, 3, 0 };
        _sa.InsertMiddle(arr, i: 1, n: 9, length: 3);
        Assert.Equal(new[] { 1, 9, 2, 3 }, arr);
    }

    [Fact]
    public void InsertMiddle_AtFront_ShiftsEverything()
    {
        var arr = new[] { 4, 5, 6, 0, 0 };
        _sa.InsertMiddle(arr, i: 0, n: 1, length: 3);
        Assert.Equal(new[] { 1, 4, 5, 6, 0 }, arr);
    }

    [Fact]
    public void InsertMiddle_AtLength_ActsLikeInsertEnd()
    {
        var arr = new[] { 1, 2, 0 };
        _sa.InsertMiddle(arr, i: 2, n: 3, length: 2);
        Assert.Equal(new[] { 1, 2, 3 }, arr);
    }

    [Fact]
    public void InsertMiddle_IntoEmptyArray()
    {
        var arr = new int[2];
        _sa.InsertMiddle(arr, i: 0, n: 8, length: 0);
        Assert.Equal(new[] { 8, 0 }, arr);
    }

    [Fact]
    public void InsertMiddle_KeepsOrderOfShiftedValues()
    {
        // Shifting must go from the end backwards, or values get overwritten.
        var arr = new[] { 10, 20, 30, 40, 0 };
        _sa.InsertMiddle(arr, i: 1, n: 15, length: 4);
        Assert.Equal(new[] { 10, 15, 20, 30, 40 }, arr);
    }

    // ---------- RemoveMiddle ----------
    // Only the first (length - 1) slots are checked: what is left in the
    // old last slot is not part of the array anymore.
    [Fact]
    public void RemoveMiddle_ShiftsLeft()
    {
        var arr = new[] { 1, 2, 3, 4 };
        _sa.RemoveMiddle(arr, i: 1, length: 4);
        Assert.Equal(new[] { 1, 3, 4 }, arr[..3]);
    }

    [Fact]
    public void RemoveMiddle_First()
    {
        var arr = new[] { 7, 8, 9 };
        _sa.RemoveMiddle(arr, i: 0, length: 3);
        Assert.Equal(new[] { 8, 9 }, arr[..2]);
    }

    [Fact]
    public void RemoveMiddle_Last_LeavesOthersUntouched()
    {
        var arr = new[] { 7, 8, 9, 0 };
        _sa.RemoveMiddle(arr, i: 2, length: 3);
        Assert.Equal(new[] { 7, 8 }, arr[..2]);
        Assert.Equal(0, arr[3]); // nothing past length is touched
    }

    [Fact]
    public void RemoveMiddle_IgnoresSlotsPastLength()
    {
        var arr = new[] { 1, 2, 3, 99, 99 };
        _sa.RemoveMiddle(arr, i: 0, length: 3);
        Assert.Equal(new[] { 2, 3 }, arr[..2]);
        Assert.Equal(99, arr[3]);
        Assert.Equal(99, arr[4]);
    }

    // ---------- PrintArr ----------
    private static string Capture(Action action)
    {
        var original = Console.Out;
        var sw = new StringWriter();
        Console.SetOut(sw);
        try { action(); }
        finally { Console.SetOut(original); }
        return sw.ToString();
    }

    [Fact]
    public void PrintArr_PrintsValuesSeparatedBySpaces()
    {
        var output = Capture(() => _sa.PrintArr(new[] { 1, 2, 3 }, 3));
        Assert.Equal("1 2 3 " + Environment.NewLine, output);
    }

    [Fact]
    public void PrintArr_OnlyPrintsUpToLength()
    {
        var output = Capture(() => _sa.PrintArr(new[] { 4, 5, 0, 0 }, 2));
        Assert.Equal("4 5 " + Environment.NewLine, output);
    }

    [Fact]
    public void PrintArr_Empty_PrintsJustNewLine()
    {
        var output = Capture(() => _sa.PrintArr(new int[3], 0));
        Assert.Equal(Environment.NewLine, output);
    }
}
