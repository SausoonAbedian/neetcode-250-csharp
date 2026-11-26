// NeetCode: Design Dynamic Array (Resizable Array)
// https://neetcode.io/problems/dynamicArray/question
// Run the tests: .\check.ps1 DynamicArrays
namespace DynamicArrays;

// Design a Dynamic Array (aka a resizable array) class,
// such as an ArrayList in Java or a vector in C++.
public class DynamicArray
{
    private int _capacity;
    private int _length;
    private int[] _arr;
    
    // Initialize an empty array with the given capacity, where capacity > 0.
    public DynamicArray(int capacity)
    {
        _capacity = capacity;
        _length = 0;
        _arr = new int[capacity];
    }

    // Return the element at index i. Assume i is valid.
    public int Get(int i)
    {
        return _arr[i];
    }

    // Set the element at index i to n. Assume i is valid.
    public void Set(int i, int n)
    {
        _arr[i] = n;
    }

    // Push n to the end of the array.
    // If the array is full, Resize() first.
    public void PushBack(int n)
    {
        if (_length == _capacity)
            Resize();

        _arr[_length] = n;
        _length++;
    }

    // Pop and return the element at the end of the array.
    // Assume the array is non-empty.
    public int PopBack()
    {
        var val = _arr[_length - 1];
        _length--;
        return val;
    }

    // Double the capacity of the array.
    public void Resize()
    {
        _capacity *= 2;
        var newArr = new int[_capacity];

        for (var i = 0; i < _length; i++)
            newArr[i] = _arr[i];

        _arr = newArr;
    }

    // Return the number of elements in the array.
    public int GetSize()
    {
        return _length;
    }

    // Return the capacity of the array.
    public int GetCapacity()
    {
        return _capacity;
    }
}
