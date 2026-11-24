# DSA practice: NeetCode 250 in C#

One xUnit project per problem (`DSA.slnx`):

- `src/LeetCode/<number>-<Name>/`: LeetCode problems, named by LeetCode number first so they sort. Long titles use a short name.
- `src/NeetCode/<Name>/`: NeetCode-only course exercises.

There is no shared project. When a problem needs `ListNode` or `TreeNode`, that class is in the problem's own project (`ListNode.cs`, with test helpers in `ListNode.Helpers.cs`).

- Problems that are free on LeetCode link to LeetCode, using LeetCode's original method signatures.
- The 7 problems that are LeetCode Premium link to NeetCode and use NeetCode's version of the problem. They are marked **(NeetCode)** below.

## Workflow

1. Open `src/LeetCode/<number>-<Name>/Solution.cs` and read the problem at the link at the top of the file.
2. Replace the `throw new NotImplementedException()` with your solution.
3. Run the tests for that problem by its LeetCode number:

   ```powershell
   .\check.ps1 206
   ```

   `.\check.ps1 1 206 1299` runs several, `.\check.ps1 <ExerciseName>` runs a NeetCode exercise, and `.\check.ps1 all` runs everything.
4. Ask Claude to check it. Claude runs the tests and reviews your approach and complexity.

`SolutionTests.cs` holds the examples plus edge cases. Avoid peeking at the edge cases if you want to find them yourself.

`tools/gen.ps1` regenerates projects, tests, `DSA.slnx` and this README from `tools/problems/*.txt`. It never overwrites an existing `Solution.cs`, `ListNode.cs` or `TreeNode.cs`.

## Problems (NeetCode 250 roadmap order)
