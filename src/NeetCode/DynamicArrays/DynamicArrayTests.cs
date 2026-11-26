namespace DynamicArrays;

public class DynamicArrayTests
{
    // ---------- Examples from the problem ----------
    [Fact]
    public void Example1_NewArray_IsEmptyWithGivenCapacity()
    {
        var arr = new DynamicArray(1);
        Assert.Equal(0, arr.GetSize());
        Assert.Equal(1, arr.GetCapacity());
    }

    [Fact]
    public void Example2_PushBackWhenFull_DoublesCapacity()
    {
        var arr = new DynamicArray(1);
        arr.PushBack(1);
        Assert.Equal(1, arr.GetCapacity());
        arr.PushBack(2);
        Assert.Equal(2, arr.GetCapacity());
    }

    [Fact]
    public void Example3_FullSequence()
    {
        var arr = new DynamicArray(1);
        Assert.Equal(0, arr.GetSize());
        Assert.Equal(1, arr.GetCapacity());

        arr.PushBack(1);
        Assert.Equal(1, arr.GetSize());
        Assert.Equal(1, arr.GetCapacity());

        arr.PushBack(2);
        Assert.Equal(2, arr.GetSize());
        Assert.Equal(2, arr.GetCapacity());

        Assert.Equal(2, arr.Get(1));
        arr.Set(1, 3);
        Assert.Equal(3, arr.Get(1));

        Assert.Equal(3, arr.PopBack());
        Assert.Equal(1, arr.GetSize());
        Assert.Equal(2, arr.GetCapacity());
    }

    // ---------- Get / Set ----------
    [Fact]
    public void Get_ReturnsPushedValuesInOrder()
    {
        var arr = new DynamicArray(4);
        arr.PushBack(10);
        arr.PushBack(20);
        arr.PushBack(30);
        Assert.Equal(10, arr.Get(0));
        Assert.Equal(20, arr.Get(1));
        Assert.Equal(30, arr.Get(2));
    }

    [Fact]
    public void Set_OverwritesWithoutChangingSize()
    {
        var arr = new DynamicArray(2);
        arr.PushBack(1);
        arr.PushBack(2);
        arr.Set(0, 7);
        Assert.Equal(7, arr.Get(0));
        Assert.Equal(2, arr.Get(1));
        Assert.Equal(2, arr.GetSize());
    }

    // ---------- PushBack / Resize ----------
    [Fact]
    public void PushBack_WithRoom_DoesNotResize()
    {
        var arr = new DynamicArray(3);
        arr.PushBack(1);
        arr.PushBack(2);
        arr.PushBack(3);
        Assert.Equal(3, arr.GetSize());
        Assert.Equal(3, arr.GetCapacity());
    }

    [Fact]
    public void PushBack_KeepsValuesAcrossResizes()
    {
        var arr = new DynamicArray(1);
        for (var i = 0; i < 9; i++)
            arr.PushBack(i * 10);

        Assert.Equal(9, arr.GetSize());
        Assert.Equal(16, arr.GetCapacity()); // 1 -> 2 -> 4 -> 8 -> 16
        for (var i = 0; i < 9; i++)
            Assert.Equal(i * 10, arr.Get(i));
    }

    [Fact]
    public void Resize_DoublesCapacityAndKeepsValues()
    {
        var arr = new DynamicArray(2);
        arr.PushBack(5);
        arr.PushBack(6);
        arr.Resize();
        Assert.Equal(4, arr.GetCapacity());
        Assert.Equal(2, arr.GetSize());
        Assert.Equal(5, arr.Get(0));
        Assert.Equal(6, arr.Get(1));
    }

    [Fact]
    public void Resize_OnEmptyArray_OnlyChangesCapacity()
    {
        var arr = new DynamicArray(3);
        arr.Resize();
        Assert.Equal(6, arr.GetCapacity());
        Assert.Equal(0, arr.GetSize());
    }

    // ---------- PopBack ----------
    [Fact]
    public void PopBack_ReturnsLastAndShrinksSize()
    {
        var arr = new DynamicArray(4);
        arr.PushBack(1);
        arr.PushBack(2);
        arr.PushBack(3);
        Assert.Equal(3, arr.PopBack());
        Assert.Equal(2, arr.PopBack());
        Assert.Equal(1, arr.GetSize());
        Assert.Equal(4, arr.GetCapacity()); // popping never shrinks capacity
    }

    [Fact]
    public void PopBack_ThenPushBack_ReusesSlot()
    {
        var arr = new DynamicArray(2);
        arr.PushBack(1);
        arr.PushBack(2);
        arr.PopBack();
        arr.PushBack(9);
        Assert.Equal(9, arr.Get(1));
        Assert.Equal(2, arr.GetSize());
        Assert.Equal(2, arr.GetCapacity());
    }
}
