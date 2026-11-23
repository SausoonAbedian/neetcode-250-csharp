// 047. Guess Number Higher Or Lower (Easy) - LeetCode #374
// https://leetcode.com/problems/guess-number-higher-or-lower/
// Run the tests: .\check.ps1 47
namespace NC047_GuessNumberHigherOrLower;

/**
 * The guess API is defined in the parent class GuessGame (provided below, do not edit).
 * int guess(int num) returns -1 if num is higher than the pick,
 *                            1 if num is lower than the pick,
 *                            0 if num == pick.
 */
public class Solution : GuessGame
{
    public Solution(int pick) : base(pick) { }

    public int GuessNumber(int n)
    {
        throw new NotImplementedException();
    }
}

// ---- provided ----
public class GuessGame
{
    private readonly int _pick;
    public int Calls { get; private set; }
    public GuessGame(int pick) => _pick = pick;

    public int guess(int num)
    {
        Calls++;
        return num > _pick ? -1 : num < _pick ? 1 : 0;
    }
}
