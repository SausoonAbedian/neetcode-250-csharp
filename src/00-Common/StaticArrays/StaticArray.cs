// NeetCode course: Data Structures & Algorithms for Beginners - Static Arrays
// https://neetcode.io/courses/dsa-for-beginners/2
// Run the tests: .\check.ps1 StaticArrays
namespace StaticArrays;

public class StaticArray
{
    // Insert n into arr at the next open position.
    // Length is the number of 'real' values in arr, and capacity
    // is the size (aka memory allocated for the fixed size array).
    // If the array is full, do nothing.
    public void InsertEnd(int[] arr, int n, int length, int capacity)
    {
        if (length == capacity)
            return;

        arr[length] = n;
    }

    // Remove from the last position in the array if the array
    // is not empty (i.e. length is non-zero).
    // Overwrite the removed slot with the default value 0.
    public void RemoveEnd(int[] arr, int length)
    {
        if (length == 0)
            return;

        arr[length - 1] = 0;
    }

    // Insert n into index i after shifting elements to the right.
    // Assuming i is a valid index and arr is not full.
    public void InsertMiddle(int[] arr, int i, int n, int length)
    {
        if (length == arr.Length || i < 0 || i > length)
            return;

        for (int x = length - 1; x >= i; x--)
            arr[x + 1] = arr[x];

        arr[i] = n;
    }

    // Remove value at index i before shifting elements to the left.
    // Assuming i is a valid index.
    public void RemoveMiddle(int[] arr, int i, int length)
    {
        if (length == 0 || i < 0 || i >= length)
            return;

        for (var x = i; x < length - 1; x++)
            arr[x] = arr[x + 1];

        arr[length - 1] = 0;
    }

    // Print the first `length` values, each followed by a space,
    // then end the line. Example: [1, 2, 3] -> "1 2 3 \n"
    public void PrintArr(int[] arr, int length)
    {
        for (var x = 0; x < length; x++)
            Console.Write(arr[x] + " ");

        Console.WriteLine();
    }
}
