# DSA practice: NeetCode 250 in C#

One xUnit project per problem, in NeetCode 250 roadmap order (`DSA.slnx`).

- Problems that are free on LeetCode link to LeetCode, using LeetCode's original method signatures.
- The 7 problems that are LeetCode Premium link to NeetCode and use NeetCode's version of the problem. They are marked **(NeetCode)** below.

## Workflow

1. Open `src/<topic>/<nnn>-<Name>/Solution.cs` and read the problem at the link at the top of the file.
2. Replace the `throw new NotImplementedException()` with your solution.
3. Run the tests for that problem:

   ```powershell
   .\check.ps1 1
   ```

   `.\check.ps1 1 2 3` runs several, and `.\check.ps1 all` runs everything.
4. Ask Claude to check it. Claude runs the tests and reviews your approach and complexity.

`SolutionTests.cs` holds the examples plus edge cases. Avoid peeking at the edge cases if you want to find them yourself.
Shared helpers live in `src/Common`: `ListNode.From(1,2,3)`, `TreeNode.From(3,9,20,null,null,15,7)`, plus their `ToArray` counterparts.

`tools/gen.ps1` regenerates projects, tests, `DSA.slnx` and this README from `tools/problems/*.txt`. It never overwrites an existing `Solution.cs`.

## Problems
