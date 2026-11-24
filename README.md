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

### Arrays & Hashing

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 1929 | [Concatenation of Array](https://leetcode.com/problems/concatenation-of-array/) | Easy | [1929-ConcatenationOfArray](src/LeetCode/1929-ConcatenationOfArray/Solution.cs) |
| 217 | [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/) | Easy | [0217-ContainsDuplicate](src/LeetCode/0217-ContainsDuplicate/Solution.cs) |
| 242 | [Valid Anagram](https://leetcode.com/problems/valid-anagram/) | Easy | [0242-ValidAnagram](src/LeetCode/0242-ValidAnagram/Solution.cs) |
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | Easy | [0001-TwoSum](src/LeetCode/0001-TwoSum/Solution.cs) |
| 14 | [Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/) | Easy | [0014-LongestCommonPrefix](src/LeetCode/0014-LongestCommonPrefix/Solution.cs) |
| 49 | [Group Anagrams](https://leetcode.com/problems/group-anagrams/) | Medium | [0049-GroupAnagrams](src/LeetCode/0049-GroupAnagrams/Solution.cs) |
| 27 | [Remove Element](https://leetcode.com/problems/remove-element/) | Easy | [0027-RemoveElement](src/LeetCode/0027-RemoveElement/Solution.cs) |
| 169 | [Majority Element](https://leetcode.com/problems/majority-element/) | Easy | [0169-MajorityElement](src/LeetCode/0169-MajorityElement/Solution.cs) |
| 705 | [Design HashSet](https://leetcode.com/problems/design-hashset/) | Easy | [0705-DesignHashSet](src/LeetCode/0705-DesignHashSet/Solution.cs) |
| 706 | [Design HashMap](https://leetcode.com/problems/design-hashmap/) | Easy | [0706-DesignHashMap](src/LeetCode/0706-DesignHashMap/Solution.cs) |
| 912 | [Sort an Array](https://leetcode.com/problems/sort-an-array/) | Medium | [0912-SortAnArray](src/LeetCode/0912-SortAnArray/Solution.cs) |
| 75 | [Sort Colors](https://leetcode.com/problems/sort-colors/) | Medium | [0075-SortColors](src/LeetCode/0075-SortColors/Solution.cs) |
| 347 | [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | Medium | [0347-TopKFrequentElements](src/LeetCode/0347-TopKFrequentElements/Solution.cs) |
| 271 | [Encode and Decode Strings](https://neetcode.io/problems/string-encode-and-decode/question) (NeetCode) | Medium | [0271-EncodeAndDecodeStrings](src/LeetCode/0271-EncodeAndDecodeStrings/Solution.cs) |
| 304 | [Range Sum Query 2D Immutable](https://leetcode.com/problems/range-sum-query-2d-immutable/) | Medium | [0304-RangeSumQuery2DImmutable](src/LeetCode/0304-RangeSumQuery2DImmutable/Solution.cs) |
| 238 | [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) | Medium | [0238-ProductOfArrayExceptSelf](src/LeetCode/0238-ProductOfArrayExceptSelf/Solution.cs) |
| 36 | [Valid Sudoku](https://leetcode.com/problems/valid-sudoku/) | Medium | [0036-ValidSudoku](src/LeetCode/0036-ValidSudoku/Solution.cs) |
| 128 | [Longest Consecutive Sequence](https://leetcode.com/problems/longest-consecutive-sequence/) | Medium | [0128-LongestConsecutiveSeq](src/LeetCode/0128-LongestConsecutiveSeq/Solution.cs) |
| 122 | [Best Time to Buy And Sell Stock II](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/) | Medium | [0122-BestTimeToBuySellStockII](src/LeetCode/0122-BestTimeToBuySellStockII/Solution.cs) |
| 229 | [Majority Element II](https://leetcode.com/problems/majority-element-ii/) | Medium | [0229-MajorityElementII](src/LeetCode/0229-MajorityElementII/Solution.cs) |
| 560 | [Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/) | Medium | [0560-SubarraySumEqualsK](src/LeetCode/0560-SubarraySumEqualsK/Solution.cs) |
| 41 | [First Missing Positive](https://leetcode.com/problems/first-missing-positive/) | Hard | [0041-FirstMissingPositive](src/LeetCode/0041-FirstMissingPositive/Solution.cs) |

### Two Pointers

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 344 | [Reverse String](https://leetcode.com/problems/reverse-string/) | Easy | [0344-ReverseString](src/LeetCode/0344-ReverseString/Solution.cs) |
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | Easy | [0125-ValidPalindrome](src/LeetCode/0125-ValidPalindrome/Solution.cs) |
| 680 | [Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/) | Easy | [0680-ValidPalindromeII](src/LeetCode/0680-ValidPalindromeII/Solution.cs) |
| 1768 | [Merge Strings Alternately](https://leetcode.com/problems/merge-strings-alternately/) | Easy | [1768-MergeStringsAlternately](src/LeetCode/1768-MergeStringsAlternately/Solution.cs) |
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | Easy | [0088-MergeSortedArray](src/LeetCode/0088-MergeSortedArray/Solution.cs) |
| 26 | [Remove Duplicates From Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) | Easy | [0026-RemoveDuplicatesSorted](src/LeetCode/0026-RemoveDuplicatesSorted/Solution.cs) |
| 167 | [Two Sum II Input Array Is Sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) | Medium | [0167-TwoSumIISorted](src/LeetCode/0167-TwoSumIISorted/Solution.cs) |
| 15 | [3Sum](https://leetcode.com/problems/3sum/) | Medium | [0015-3Sum](src/LeetCode/0015-3Sum/Solution.cs) |
| 18 | [4Sum](https://leetcode.com/problems/4sum/) | Medium | [0018-4Sum](src/LeetCode/0018-4Sum/Solution.cs) |
| 189 | [Rotate Array](https://leetcode.com/problems/rotate-array/) | Medium | [0189-RotateArray](src/LeetCode/0189-RotateArray/Solution.cs) |
| 11 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | Medium | [0011-ContainerWithMostWater](src/LeetCode/0011-ContainerWithMostWater/Solution.cs) |
| 881 | [Boats to Save People](https://leetcode.com/problems/boats-to-save-people/) | Medium | [0881-BoatsToSavePeople](src/LeetCode/0881-BoatsToSavePeople/Solution.cs) |
| 42 | [Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water/) | Hard | [0042-TrappingRainWater](src/LeetCode/0042-TrappingRainWater/Solution.cs) |

### Sliding Window

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 219 | [Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii/) | Easy | [0219-ContainsDuplicateII](src/LeetCode/0219-ContainsDuplicateII/Solution.cs) |
| 121 | [Best Time to Buy And Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | Easy | [0121-BestTimeToBuySellStock](src/LeetCode/0121-BestTimeToBuySellStock/Solution.cs) |
| 3 | [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | Medium | [0003-LongestSubstringNoRepeat](src/LeetCode/0003-LongestSubstringNoRepeat/Solution.cs) |
| 424 | [Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/) | Medium | [0424-LongestRepeatingCharRepl](src/LeetCode/0424-LongestRepeatingCharRepl/Solution.cs) |
| 567 | [Permutation In String](https://leetcode.com/problems/permutation-in-string/) | Medium | [0567-PermutationInString](src/LeetCode/0567-PermutationInString/Solution.cs) |
| 209 | [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/) | Medium | [0209-MinimumSizeSubarraySum](src/LeetCode/0209-MinimumSizeSubarraySum/Solution.cs) |
| 658 | [Find K Closest Elements](https://leetcode.com/problems/find-k-closest-elements/) | Medium | [0658-FindKClosestElements](src/LeetCode/0658-FindKClosestElements/Solution.cs) |
| 76 | [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/) | Hard | [0076-MinimumWindowSubstring](src/LeetCode/0076-MinimumWindowSubstring/Solution.cs) |
| 239 | [Sliding Window Maximum](https://leetcode.com/problems/sliding-window-maximum/) | Hard | [0239-SlidingWindowMaximum](src/LeetCode/0239-SlidingWindowMaximum/Solution.cs) |

### Binary Search

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 704 | [Binary Search](https://leetcode.com/problems/binary-search/) | Easy | [0704-BinarySearch](src/LeetCode/0704-BinarySearch/Solution.cs) |
| 35 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | Easy | [0035-SearchInsertPosition](src/LeetCode/0035-SearchInsertPosition/Solution.cs) |
| 374 | [Guess Number Higher Or Lower](https://leetcode.com/problems/guess-number-higher-or-lower/) | Easy | [0374-GuessNumberHigherOrLower](src/LeetCode/0374-GuessNumberHigherOrLower/Solution.cs) |
| 69 | [Sqrt(x)](https://leetcode.com/problems/sqrtx/) | Easy | [0069-SqrtX](src/LeetCode/0069-SqrtX/Solution.cs) |
| 74 | [Search a 2D Matrix](https://leetcode.com/problems/search-a-2d-matrix/) | Medium | [0074-SearchA2DMatrix](src/LeetCode/0074-SearchA2DMatrix/Solution.cs) |
| 875 | [Koko Eating Bananas](https://leetcode.com/problems/koko-eating-bananas/) | Medium | [0875-KokoEatingBananas](src/LeetCode/0875-KokoEatingBananas/Solution.cs) |
| 1011 | [Capacity to Ship Packages Within D Days](https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/) | Medium | [1011-ShipPackagesInDDays](src/LeetCode/1011-ShipPackagesInDDays/Solution.cs) |
| 153 | [Find Minimum In Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/) | Medium | [0153-FindMinInRotatedArray](src/LeetCode/0153-FindMinInRotatedArray/Solution.cs) |
| 33 | [Search In Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | Medium | [0033-SearchRotatedArray](src/LeetCode/0033-SearchRotatedArray/Solution.cs) |
| 81 | [Search In Rotated Sorted Array II](https://leetcode.com/problems/search-in-rotated-sorted-array-ii/) | Medium | [0081-SearchRotatedArrayII](src/LeetCode/0081-SearchRotatedArrayII/Solution.cs) |
| 981 | [Time Based Key Value Store](https://leetcode.com/problems/time-based-key-value-store/) | Medium | [0981-TimeBasedKeyValueStore](src/LeetCode/0981-TimeBasedKeyValueStore/Solution.cs) |
| 410 | [Split Array Largest Sum](https://leetcode.com/problems/split-array-largest-sum/) | Hard | [0410-SplitArrayLargestSum](src/LeetCode/0410-SplitArrayLargestSum/Solution.cs) |
| 4 | [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/) | Hard | [0004-MedianOfTwoSortedArrays](src/LeetCode/0004-MedianOfTwoSortedArrays/Solution.cs) |
| 1095 | [Find in Mountain Array](https://leetcode.com/problems/find-in-mountain-array/) | Hard | [1095-FindInMountainArray](src/LeetCode/1095-FindInMountainArray/Solution.cs) |

### Linked List

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 206 | [Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/) | Easy | [0206-ReverseLinkedList](src/LeetCode/0206-ReverseLinkedList/Solution.cs) |
| 21 | [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/) | Easy | [0021-MergeTwoSortedLists](src/LeetCode/0021-MergeTwoSortedLists/Solution.cs) |
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | Easy | [0141-LinkedListCycle](src/LeetCode/0141-LinkedListCycle/Solution.cs) |
| 143 | [Reorder List](https://leetcode.com/problems/reorder-list/) | Medium | [0143-ReorderList](src/LeetCode/0143-ReorderList/Solution.cs) |
| 19 | [Remove Nth Node From End of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/) | Medium | [0019-RemoveNthFromEnd](src/LeetCode/0019-RemoveNthFromEnd/Solution.cs) |
| 138 | [Copy List With Random Pointer](https://leetcode.com/problems/copy-list-with-random-pointer/) | Medium | [0138-CopyListRandomPointer](src/LeetCode/0138-CopyListRandomPointer/Solution.cs) |
| 2 | [Add Two Numbers](https://leetcode.com/problems/add-two-numbers/) | Medium | [0002-AddTwoNumbers](src/LeetCode/0002-AddTwoNumbers/Solution.cs) |
| 287 | [Find The Duplicate Number](https://leetcode.com/problems/find-the-duplicate-number/) | Medium | [0287-FindTheDuplicateNumber](src/LeetCode/0287-FindTheDuplicateNumber/Solution.cs) |
| 92 | [Reverse Linked List II](https://leetcode.com/problems/reverse-linked-list-ii/) | Medium | [0092-ReverseLinkedListII](src/LeetCode/0092-ReverseLinkedListII/Solution.cs) |
| 622 | [Design Circular Queue](https://leetcode.com/problems/design-circular-queue/) | Medium | [0622-DesignCircularQueue](src/LeetCode/0622-DesignCircularQueue/Solution.cs) |
| 146 | [LRU Cache](https://leetcode.com/problems/lru-cache/) | Medium | [0146-LRUCache](src/LeetCode/0146-LRUCache/Solution.cs) |
| 460 | [LFU Cache](https://leetcode.com/problems/lfu-cache/) | Hard | [0460-LFUCache](src/LeetCode/0460-LFUCache/Solution.cs) |
| 23 | [Merge K Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/) | Hard | [0023-MergeKSortedLists](src/LeetCode/0023-MergeKSortedLists/Solution.cs) |
| 25 | [Reverse Nodes In K Group](https://leetcode.com/problems/reverse-nodes-in-k-group/) | Hard | [0025-ReverseNodesInKGroup](src/LeetCode/0025-ReverseNodesInKGroup/Solution.cs) |

### Stack

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 682 | [Baseball Game](https://leetcode.com/problems/baseball-game/) | Easy | [0682-BaseballGame](src/LeetCode/0682-BaseballGame/Solution.cs) |
| 20 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | Easy | [0020-ValidParentheses](src/LeetCode/0020-ValidParentheses/Solution.cs) |
| 225 | [Implement Stack Using Queues](https://leetcode.com/problems/implement-stack-using-queues/) | Easy | [0225-StackUsingQueues](src/LeetCode/0225-StackUsingQueues/Solution.cs) |
| 232 | [Implement Queue using Stacks](https://leetcode.com/problems/implement-queue-using-stacks/) | Easy | [0232-QueueUsingStacks](src/LeetCode/0232-QueueUsingStacks/Solution.cs) |
| 155 | [Min Stack](https://leetcode.com/problems/min-stack/) | Medium | [0155-MinStack](src/LeetCode/0155-MinStack/Solution.cs) |
| 150 | [Evaluate Reverse Polish Notation](https://leetcode.com/problems/evaluate-reverse-polish-notation/) | Medium | [0150-EvalReversePolishNotation](src/LeetCode/0150-EvalReversePolishNotation/Solution.cs) |
| 735 | [Asteroid Collision](https://leetcode.com/problems/asteroid-collision/) | Medium | [0735-AsteroidCollision](src/LeetCode/0735-AsteroidCollision/Solution.cs) |
| 739 | [Daily Temperatures](https://leetcode.com/problems/daily-temperatures/) | Medium | [0739-DailyTemperatures](src/LeetCode/0739-DailyTemperatures/Solution.cs) |
| 901 | [Online Stock Span](https://leetcode.com/problems/online-stock-span/) | Medium | [0901-OnlineStockSpan](src/LeetCode/0901-OnlineStockSpan/Solution.cs) |
| 853 | [Car Fleet](https://leetcode.com/problems/car-fleet/) | Medium | [0853-CarFleet](src/LeetCode/0853-CarFleet/Solution.cs) |
| 71 | [Simplify Path](https://leetcode.com/problems/simplify-path/) | Medium | [0071-SimplifyPath](src/LeetCode/0071-SimplifyPath/Solution.cs) |
| 394 | [Decode String](https://leetcode.com/problems/decode-string/) | Medium | [0394-DecodeString](src/LeetCode/0394-DecodeString/Solution.cs) |
| 895 | [Maximum Frequency Stack](https://leetcode.com/problems/maximum-frequency-stack/) | Hard | [0895-MaximumFrequencyStack](src/LeetCode/0895-MaximumFrequencyStack/Solution.cs) |
| 84 | [Largest Rectangle In Histogram](https://leetcode.com/problems/largest-rectangle-in-histogram/) | Hard | [0084-LargestRectInHistogram](src/LeetCode/0084-LargestRectInHistogram/Solution.cs) |

### Trees

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 94 | [Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/) | Easy | [0094-InorderTraversal](src/LeetCode/0094-InorderTraversal/Solution.cs) |
| 144 | [Binary Tree Preorder Traversal](https://leetcode.com/problems/binary-tree-preorder-traversal/) | Easy | [0144-PreorderTraversal](src/LeetCode/0144-PreorderTraversal/Solution.cs) |
| 145 | [Binary Tree Postorder Traversal](https://leetcode.com/problems/binary-tree-postorder-traversal/) | Easy | [0145-PostorderTraversal](src/LeetCode/0145-PostorderTraversal/Solution.cs) |
| 226 | [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/) | Easy | [0226-InvertBinaryTree](src/LeetCode/0226-InvertBinaryTree/Solution.cs) |
| 104 | [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/) | Easy | [0104-MaximumDepthOfBinaryTree](src/LeetCode/0104-MaximumDepthOfBinaryTree/Solution.cs) |
| 543 | [Diameter of Binary Tree](https://leetcode.com/problems/diameter-of-binary-tree/) | Easy | [0543-DiameterOfBinaryTree](src/LeetCode/0543-DiameterOfBinaryTree/Solution.cs) |
| 110 | [Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree/) | Easy | [0110-BalancedBinaryTree](src/LeetCode/0110-BalancedBinaryTree/Solution.cs) |
| 100 | [Same Tree](https://leetcode.com/problems/same-tree/) | Easy | [0100-SameTree](src/LeetCode/0100-SameTree/Solution.cs) |
| 572 | [Subtree of Another Tree](https://leetcode.com/problems/subtree-of-another-tree/) | Easy | [0572-SubtreeOfAnotherTree](src/LeetCode/0572-SubtreeOfAnotherTree/Solution.cs) |
| 235 | [Lowest Common Ancestor of a Binary Search Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/) | Medium | [0235-LcaOfBst](src/LeetCode/0235-LcaOfBst/Solution.cs) |
| 701 | [Insert into a Binary Search Tree](https://leetcode.com/problems/insert-into-a-binary-search-tree/) | Medium | [0701-InsertIntoBst](src/LeetCode/0701-InsertIntoBst/Solution.cs) |
| 450 | [Delete Node in a BST](https://leetcode.com/problems/delete-node-in-a-bst/) | Medium | [0450-DeleteNodeInABST](src/LeetCode/0450-DeleteNodeInABST/Solution.cs) |
| 102 | [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/) | Medium | [0102-LevelOrderTraversal](src/LeetCode/0102-LevelOrderTraversal/Solution.cs) |
| 199 | [Binary Tree Right Side View](https://leetcode.com/problems/binary-tree-right-side-view/) | Medium | [0199-BinaryTreeRightSideView](src/LeetCode/0199-BinaryTreeRightSideView/Solution.cs) |
| 427 | [Construct Quad Tree](https://leetcode.com/problems/construct-quad-tree/) | Medium | [0427-ConstructQuadTree](src/LeetCode/0427-ConstructQuadTree/Solution.cs) |
| 1448 | [Count Good Nodes In Binary Tree](https://leetcode.com/problems/count-good-nodes-in-binary-tree/) | Medium | [1448-CountGoodNodes](src/LeetCode/1448-CountGoodNodes/Solution.cs) |
| 98 | [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/) | Medium | [0098-ValidateBinarySearchTree](src/LeetCode/0098-ValidateBinarySearchTree/Solution.cs) |
| 230 | [Kth Smallest Element In a Bst](https://leetcode.com/problems/kth-smallest-element-in-a-bst/) | Medium | [0230-KthSmallestElementInABst](src/LeetCode/0230-KthSmallestElementInABst/Solution.cs) |
| 105 | [Construct Binary Tree From Preorder And Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/) | Medium | [0105-TreeFromPreorderInorder](src/LeetCode/0105-TreeFromPreorderInorder/Solution.cs) |
| 337 | [House Robber III](https://leetcode.com/problems/house-robber-iii/) | Medium | [0337-HouseRobberIII](src/LeetCode/0337-HouseRobberIII/Solution.cs) |
| 1325 | [Delete Leaves With a Given Value](https://leetcode.com/problems/delete-leaves-with-a-given-value/) | Medium | [1325-DeleteLeavesWithValue](src/LeetCode/1325-DeleteLeavesWithValue/Solution.cs) |
| 124 | [Binary Tree Maximum Path Sum](https://leetcode.com/problems/binary-tree-maximum-path-sum/) | Hard | [0124-BinaryTreeMaximumPathSum](src/LeetCode/0124-BinaryTreeMaximumPathSum/Solution.cs) |
| 297 | [Serialize And Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/) | Hard | [0297-SerializeDeserializeTree](src/LeetCode/0297-SerializeDeserializeTree/Solution.cs) |

### Tries

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 208 | [Implement Trie Prefix Tree](https://leetcode.com/problems/implement-trie-prefix-tree/) | Medium | [0208-ImplementTriePrefixTree](src/LeetCode/0208-ImplementTriePrefixTree/Solution.cs) |
| 211 | [Design Add And Search Words Data Structure](https://leetcode.com/problems/design-add-and-search-words-data-structure/) | Medium | [0211-AddAndSearchWords](src/LeetCode/0211-AddAndSearchWords/Solution.cs) |
| 2707 | [Extra Characters in a String](https://leetcode.com/problems/extra-characters-in-a-string/) | Medium | [2707-ExtraCharactersInAString](src/LeetCode/2707-ExtraCharactersInAString/Solution.cs) |
| 212 | [Word Search II](https://leetcode.com/problems/word-search-ii/) | Hard | [0212-WordSearchII](src/LeetCode/0212-WordSearchII/Solution.cs) |

### Backtracking

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 1863 | [Sum of All Subsets XOR Total](https://leetcode.com/problems/sum-of-all-subset-xor-totals/) | Easy | [1863-SumOfAllSubsetsXORTotal](src/LeetCode/1863-SumOfAllSubsetsXORTotal/Solution.cs) |
| 78 | [Subsets](https://leetcode.com/problems/subsets/) | Medium | [0078-Subsets](src/LeetCode/0078-Subsets/Solution.cs) |
| 39 | [Combination Sum](https://leetcode.com/problems/combination-sum/) | Medium | [0039-CombinationSum](src/LeetCode/0039-CombinationSum/Solution.cs) |
| 40 | [Combination Sum II](https://leetcode.com/problems/combination-sum-ii/) | Medium | [0040-CombinationSumII](src/LeetCode/0040-CombinationSumII/Solution.cs) |
| 77 | [Combinations](https://leetcode.com/problems/combinations/) | Medium | [0077-Combinations](src/LeetCode/0077-Combinations/Solution.cs) |
| 46 | [Permutations](https://leetcode.com/problems/permutations/) | Medium | [0046-Permutations](src/LeetCode/0046-Permutations/Solution.cs) |
| 90 | [Subsets II](https://leetcode.com/problems/subsets-ii/) | Medium | [0090-SubsetsII](src/LeetCode/0090-SubsetsII/Solution.cs) |
| 47 | [Permutations II](https://leetcode.com/problems/permutations-ii/) | Medium | [0047-PermutationsII](src/LeetCode/0047-PermutationsII/Solution.cs) |
| 22 | [Generate Parentheses](https://leetcode.com/problems/generate-parentheses/) | Medium | [0022-GenerateParentheses](src/LeetCode/0022-GenerateParentheses/Solution.cs) |
| 79 | [Word Search](https://leetcode.com/problems/word-search/) | Medium | [0079-WordSearch](src/LeetCode/0079-WordSearch/Solution.cs) |
| 131 | [Palindrome Partitioning](https://leetcode.com/problems/palindrome-partitioning/) | Medium | [0131-PalindromePartitioning](src/LeetCode/0131-PalindromePartitioning/Solution.cs) |
| 17 | [Letter Combinations of a Phone Number](https://leetcode.com/problems/letter-combinations-of-a-phone-number/) | Medium | [0017-PhoneLetterCombinations](src/LeetCode/0017-PhoneLetterCombinations/Solution.cs) |
| 473 | [Matchsticks to Square](https://leetcode.com/problems/matchsticks-to-square/) | Medium | [0473-MatchsticksToSquare](src/LeetCode/0473-MatchsticksToSquare/Solution.cs) |
| 698 | [Partition to K Equal Sum Subsets](https://leetcode.com/problems/partition-to-k-equal-sum-subsets/) | Medium | [0698-PartitionKEqualSubsets](src/LeetCode/0698-PartitionKEqualSubsets/Solution.cs) |
| 51 | [N Queens](https://leetcode.com/problems/n-queens/) | Hard | [0051-NQueens](src/LeetCode/0051-NQueens/Solution.cs) |
| 52 | [N Queens II](https://leetcode.com/problems/n-queens-ii/) | Hard | [0052-NQueensII](src/LeetCode/0052-NQueensII/Solution.cs) |
| 140 | [Word Break II](https://leetcode.com/problems/word-break-ii/) | Hard | [0140-WordBreakII](src/LeetCode/0140-WordBreakII/Solution.cs) |

### Heap / Priority Queue

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 703 | [Kth Largest Element In a Stream](https://leetcode.com/problems/kth-largest-element-in-a-stream/) | Easy | [0703-KthLargestInStream](src/LeetCode/0703-KthLargestInStream/Solution.cs) |
| 1046 | [Last Stone Weight](https://leetcode.com/problems/last-stone-weight/) | Easy | [1046-LastStoneWeight](src/LeetCode/1046-LastStoneWeight/Solution.cs) |
| 973 | [K Closest Points to Origin](https://leetcode.com/problems/k-closest-points-to-origin/) | Medium | [0973-KClosestPointsToOrigin](src/LeetCode/0973-KClosestPointsToOrigin/Solution.cs) |
| 215 | [Kth Largest Element In An Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | Medium | [0215-KthLargestInArray](src/LeetCode/0215-KthLargestInArray/Solution.cs) |
| 621 | [Task Scheduler](https://leetcode.com/problems/task-scheduler/) | Medium | [0621-TaskScheduler](src/LeetCode/0621-TaskScheduler/Solution.cs) |
| 355 | [Design Twitter](https://leetcode.com/problems/design-twitter/) | Medium | [0355-DesignTwitter](src/LeetCode/0355-DesignTwitter/Solution.cs) |
| 1834 | [Single Threaded CPU](https://leetcode.com/problems/single-threaded-cpu/) | Medium | [1834-SingleThreadedCPU](src/LeetCode/1834-SingleThreadedCPU/Solution.cs) |
| 767 | [Reorganize String](https://leetcode.com/problems/reorganize-string/) | Medium | [0767-ReorganizeString](src/LeetCode/0767-ReorganizeString/Solution.cs) |
| 1405 | [Longest Happy String](https://leetcode.com/problems/longest-happy-string/) | Medium | [1405-LongestHappyString](src/LeetCode/1405-LongestHappyString/Solution.cs) |
| 1094 | [Car Pooling](https://leetcode.com/problems/car-pooling/) | Medium | [1094-CarPooling](src/LeetCode/1094-CarPooling/Solution.cs) |
| 295 | [Find Median From Data Stream](https://leetcode.com/problems/find-median-from-data-stream/) | Hard | [0295-FindMedianFromDataStream](src/LeetCode/0295-FindMedianFromDataStream/Solution.cs) |
| 502 | [IPO](https://leetcode.com/problems/ipo/) | Hard | [0502-IPO](src/LeetCode/0502-IPO/Solution.cs) |

### Graphs

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 463 | [Island Perimeter](https://leetcode.com/problems/island-perimeter/) | Easy | [0463-IslandPerimeter](src/LeetCode/0463-IslandPerimeter/Solution.cs) |
| 953 | [Verifying An Alien Dictionary](https://leetcode.com/problems/verifying-an-alien-dictionary/) | Easy | [0953-VerifyAlienDictionary](src/LeetCode/0953-VerifyAlienDictionary/Solution.cs) |
| 997 | [Find the Town Judge](https://leetcode.com/problems/find-the-town-judge/) | Easy | [0997-FindTheTownJudge](src/LeetCode/0997-FindTheTownJudge/Solution.cs) |
| 200 | [Number of Islands](https://leetcode.com/problems/number-of-islands/) | Medium | [0200-NumberOfIslands](src/LeetCode/0200-NumberOfIslands/Solution.cs) |
| 695 | [Max Area of Island](https://leetcode.com/problems/max-area-of-island/) | Medium | [0695-MaxAreaOfIsland](src/LeetCode/0695-MaxAreaOfIsland/Solution.cs) |
| 133 | [Clone Graph](https://leetcode.com/problems/clone-graph/) | Medium | [0133-CloneGraph](src/LeetCode/0133-CloneGraph/Solution.cs) |
| 286 | [Walls And Gates](https://neetcode.io/problems/islands-and-treasure/question) (NeetCode) | Medium | [0286-WallsAndGates](src/LeetCode/0286-WallsAndGates/Solution.cs) |
| 994 | [Rotting Oranges](https://leetcode.com/problems/rotting-oranges/) | Medium | [0994-RottingOranges](src/LeetCode/0994-RottingOranges/Solution.cs) |
| 417 | [Pacific Atlantic Water Flow](https://leetcode.com/problems/pacific-atlantic-water-flow/) | Medium | [0417-PacificAtlanticWaterFlow](src/LeetCode/0417-PacificAtlanticWaterFlow/Solution.cs) |
| 130 | [Surrounded Regions](https://leetcode.com/problems/surrounded-regions/) | Medium | [0130-SurroundedRegions](src/LeetCode/0130-SurroundedRegions/Solution.cs) |
| 752 | [Open The Lock](https://leetcode.com/problems/open-the-lock/) | Medium | [0752-OpenTheLock](src/LeetCode/0752-OpenTheLock/Solution.cs) |
| 207 | [Course Schedule](https://leetcode.com/problems/course-schedule/) | Medium | [0207-CourseSchedule](src/LeetCode/0207-CourseSchedule/Solution.cs) |
| 210 | [Course Schedule II](https://leetcode.com/problems/course-schedule-ii/) | Medium | [0210-CourseScheduleII](src/LeetCode/0210-CourseScheduleII/Solution.cs) |
| 261 | [Graph Valid Tree](https://neetcode.io/problems/valid-tree/question) (NeetCode) | Medium | [0261-GraphValidTree](src/LeetCode/0261-GraphValidTree/Solution.cs) |
| 1462 | [Course Schedule IV](https://leetcode.com/problems/course-schedule-iv/) | Medium | [1462-CourseScheduleIV](src/LeetCode/1462-CourseScheduleIV/Solution.cs) |
| 323 | [Number of Connected Components In An Undirected Graph](https://neetcode.io/problems/count-connected-components/question) (NeetCode) | Medium | [0323-ConnectedComponents](src/LeetCode/0323-ConnectedComponents/Solution.cs) |
| 684 | [Redundant Connection](https://leetcode.com/problems/redundant-connection/) | Medium | [0684-RedundantConnection](src/LeetCode/0684-RedundantConnection/Solution.cs) |
| 721 | [Accounts Merge](https://leetcode.com/problems/accounts-merge/) | Medium | [0721-AccountsMerge](src/LeetCode/0721-AccountsMerge/Solution.cs) |
| 399 | [Evaluate Division](https://leetcode.com/problems/evaluate-division/) | Medium | [0399-EvaluateDivision](src/LeetCode/0399-EvaluateDivision/Solution.cs) |
| 310 | [Minimum Height Trees](https://leetcode.com/problems/minimum-height-trees/) | Medium | [0310-MinimumHeightTrees](src/LeetCode/0310-MinimumHeightTrees/Solution.cs) |
| 127 | [Word Ladder](https://leetcode.com/problems/word-ladder/) | Hard | [0127-WordLadder](src/LeetCode/0127-WordLadder/Solution.cs) |

### Advanced Graphs

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 1631 | [Path with Minimum Effort](https://leetcode.com/problems/path-with-minimum-effort/) | Medium | [1631-PathWithMinimumEffort](src/LeetCode/1631-PathWithMinimumEffort/Solution.cs) |
| 743 | [Network Delay Time](https://leetcode.com/problems/network-delay-time/) | Medium | [0743-NetworkDelayTime](src/LeetCode/0743-NetworkDelayTime/Solution.cs) |
| 332 | [Reconstruct Itinerary](https://leetcode.com/problems/reconstruct-itinerary/) | Hard | [0332-ReconstructItinerary](src/LeetCode/0332-ReconstructItinerary/Solution.cs) |
| 1584 | [Min Cost to Connect All Points](https://leetcode.com/problems/min-cost-to-connect-all-points/) | Medium | [1584-MinCostConnectPoints](src/LeetCode/1584-MinCostConnectPoints/Solution.cs) |
| 778 | [Swim In Rising Water](https://leetcode.com/problems/swim-in-rising-water/) | Hard | [0778-SwimInRisingWater](src/LeetCode/0778-SwimInRisingWater/Solution.cs) |
| 269 | [Alien Dictionary](https://neetcode.io/problems/foreign-dictionary/question) (NeetCode) | Hard | [0269-AlienDictionary](src/LeetCode/0269-AlienDictionary/Solution.cs) |
| 787 | [Cheapest Flights Within K Stops](https://leetcode.com/problems/cheapest-flights-within-k-stops/) | Medium | [0787-CheapestFlightsKStops](src/LeetCode/0787-CheapestFlightsKStops/Solution.cs) |
| 1489 | [Find Critical and Pseudo Critical Edges in Minimum Spanning Tree](https://leetcode.com/problems/find-critical-and-pseudo-critical-edges-in-minimum-spanning-tree/) | Hard | [1489-CriticalEdgesInMst](src/LeetCode/1489-CriticalEdgesInMst/Solution.cs) |
| 2392 | [Build a Matrix With Conditions](https://leetcode.com/problems/build-a-matrix-with-conditions/) | Hard | [2392-BuildMatrixConditions](src/LeetCode/2392-BuildMatrixConditions/Solution.cs) |
| 2709 | [Greatest Common Divisor Traversal](https://leetcode.com/problems/greatest-common-divisor-traversal/) | Hard | [2709-GcdTraversal](src/LeetCode/2709-GcdTraversal/Solution.cs) |

### 1-D Dynamic Programming

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 70 | [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/) | Easy | [0070-ClimbingStairs](src/LeetCode/0070-ClimbingStairs/Solution.cs) |
| 746 | [Min Cost Climbing Stairs](https://leetcode.com/problems/min-cost-climbing-stairs/) | Easy | [0746-MinCostClimbingStairs](src/LeetCode/0746-MinCostClimbingStairs/Solution.cs) |
| 1137 | [N-th Tribonacci Number](https://leetcode.com/problems/n-th-tribonacci-number/) | Easy | [1137-NThTribonacciNumber](src/LeetCode/1137-NThTribonacciNumber/Solution.cs) |
| 198 | [House Robber](https://leetcode.com/problems/house-robber/) | Medium | [0198-HouseRobber](src/LeetCode/0198-HouseRobber/Solution.cs) |
| 213 | [House Robber II](https://leetcode.com/problems/house-robber-ii/) | Medium | [0213-HouseRobberII](src/LeetCode/0213-HouseRobberII/Solution.cs) |
| 5 | [Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring/) | Medium | [0005-LongestPalSubstring](src/LeetCode/0005-LongestPalSubstring/Solution.cs) |
| 647 | [Palindromic Substrings](https://leetcode.com/problems/palindromic-substrings/) | Medium | [0647-PalindromicSubstrings](src/LeetCode/0647-PalindromicSubstrings/Solution.cs) |
| 91 | [Decode Ways](https://leetcode.com/problems/decode-ways/) | Medium | [0091-DecodeWays](src/LeetCode/0091-DecodeWays/Solution.cs) |
| 322 | [Coin Change](https://leetcode.com/problems/coin-change/) | Medium | [0322-CoinChange](src/LeetCode/0322-CoinChange/Solution.cs) |
| 152 | [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/) | Medium | [0152-MaximumProductSubarray](src/LeetCode/0152-MaximumProductSubarray/Solution.cs) |
| 139 | [Word Break](https://leetcode.com/problems/word-break/) | Medium | [0139-WordBreak](src/LeetCode/0139-WordBreak/Solution.cs) |
| 300 | [Longest Increasing Subsequence](https://leetcode.com/problems/longest-increasing-subsequence/) | Medium | [0300-LongestIncreasingSubseq](src/LeetCode/0300-LongestIncreasingSubseq/Solution.cs) |
| 416 | [Partition Equal Subset Sum](https://leetcode.com/problems/partition-equal-subset-sum/) | Medium | [0416-PartitionEqualSubsetSum](src/LeetCode/0416-PartitionEqualSubsetSum/Solution.cs) |
| 377 | [Combination Sum IV](https://leetcode.com/problems/combination-sum-iv/) | Medium | [0377-CombinationSumIV](src/LeetCode/0377-CombinationSumIV/Solution.cs) |
| 279 | [Perfect Squares](https://leetcode.com/problems/perfect-squares/) | Medium | [0279-PerfectSquares](src/LeetCode/0279-PerfectSquares/Solution.cs) |
| 343 | [Integer Break](https://leetcode.com/problems/integer-break/) | Medium | [0343-IntegerBreak](src/LeetCode/0343-IntegerBreak/Solution.cs) |
| 1406 | [Stone Game III](https://leetcode.com/problems/stone-game-iii/) | Hard | [1406-StoneGameIII](src/LeetCode/1406-StoneGameIII/Solution.cs) |

### 2-D Dynamic Programming

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 62 | [Unique Paths](https://leetcode.com/problems/unique-paths/) | Medium | [0062-UniquePaths](src/LeetCode/0062-UniquePaths/Solution.cs) |
| 63 | [Unique Paths II](https://leetcode.com/problems/unique-paths-ii/) | Medium | [0063-UniquePathsII](src/LeetCode/0063-UniquePathsII/Solution.cs) |
| 64 | [Minimum Path Sum](https://leetcode.com/problems/minimum-path-sum/) | Medium | [0064-MinimumPathSum](src/LeetCode/0064-MinimumPathSum/Solution.cs) |
| 1143 | [Longest Common Subsequence](https://leetcode.com/problems/longest-common-subsequence/) | Medium | [1143-LongestCommonSubsequence](src/LeetCode/1143-LongestCommonSubsequence/Solution.cs) |
| 1049 | [Last Stone Weight II](https://leetcode.com/problems/last-stone-weight-ii/) | Medium | [1049-LastStoneWeightII](src/LeetCode/1049-LastStoneWeightII/Solution.cs) |
| 309 | [Best Time to Buy And Sell Stock With Cooldown](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/) | Medium | [0309-StockWithCooldown](src/LeetCode/0309-StockWithCooldown/Solution.cs) |
| 518 | [Coin Change II](https://leetcode.com/problems/coin-change-ii/) | Medium | [0518-CoinChangeII](src/LeetCode/0518-CoinChangeII/Solution.cs) |
| 494 | [Target Sum](https://leetcode.com/problems/target-sum/) | Medium | [0494-TargetSum](src/LeetCode/0494-TargetSum/Solution.cs) |
| 97 | [Interleaving String](https://leetcode.com/problems/interleaving-string/) | Medium | [0097-InterleavingString](src/LeetCode/0097-InterleavingString/Solution.cs) |
| 877 | [Stone Game](https://leetcode.com/problems/stone-game/) | Medium | [0877-StoneGame](src/LeetCode/0877-StoneGame/Solution.cs) |
| 1140 | [Stone Game II](https://leetcode.com/problems/stone-game-ii/) | Medium | [1140-StoneGameII](src/LeetCode/1140-StoneGameII/Solution.cs) |
| 329 | [Longest Increasing Path In a Matrix](https://leetcode.com/problems/longest-increasing-path-in-a-matrix/) | Hard | [0329-LongestIncreasingPath](src/LeetCode/0329-LongestIncreasingPath/Solution.cs) |
| 115 | [Distinct Subsequences](https://leetcode.com/problems/distinct-subsequences/) | Hard | [0115-DistinctSubsequences](src/LeetCode/0115-DistinctSubsequences/Solution.cs) |
| 72 | [Edit Distance](https://leetcode.com/problems/edit-distance/) | Medium | [0072-EditDistance](src/LeetCode/0072-EditDistance/Solution.cs) |
| 312 | [Burst Balloons](https://leetcode.com/problems/burst-balloons/) | Hard | [0312-BurstBalloons](src/LeetCode/0312-BurstBalloons/Solution.cs) |
| 10 | [Regular Expression Matching](https://leetcode.com/problems/regular-expression-matching/) | Hard | [0010-RegexMatching](src/LeetCode/0010-RegexMatching/Solution.cs) |

### Greedy

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 860 | [Lemonade Change](https://leetcode.com/problems/lemonade-change/) | Easy | [0860-LemonadeChange](src/LeetCode/0860-LemonadeChange/Solution.cs) |
| 53 | [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/) | Medium | [0053-MaximumSubarray](src/LeetCode/0053-MaximumSubarray/Solution.cs) |
| 918 | [Maximum Sum Circular Subarray](https://leetcode.com/problems/maximum-sum-circular-subarray/) | Medium | [0918-MaxSumCircularSubarray](src/LeetCode/0918-MaxSumCircularSubarray/Solution.cs) |
| 978 | [Longest Turbulent Subarray](https://leetcode.com/problems/longest-turbulent-subarray/) | Medium | [0978-LongestTurbulentSubarray](src/LeetCode/0978-LongestTurbulentSubarray/Solution.cs) |
| 55 | [Jump Game](https://leetcode.com/problems/jump-game/) | Medium | [0055-JumpGame](src/LeetCode/0055-JumpGame/Solution.cs) |
| 45 | [Jump Game II](https://leetcode.com/problems/jump-game-ii/) | Medium | [0045-JumpGameII](src/LeetCode/0045-JumpGameII/Solution.cs) |
| 1871 | [Jump Game VII](https://leetcode.com/problems/jump-game-vii/) | Medium | [1871-JumpGameVII](src/LeetCode/1871-JumpGameVII/Solution.cs) |
| 134 | [Gas Station](https://leetcode.com/problems/gas-station/) | Medium | [0134-GasStation](src/LeetCode/0134-GasStation/Solution.cs) |
| 846 | [Hand of Straights](https://leetcode.com/problems/hand-of-straights/) | Medium | [0846-HandOfStraights](src/LeetCode/0846-HandOfStraights/Solution.cs) |
| 649 | [Dota2 Senate](https://leetcode.com/problems/dota2-senate/) | Medium | [0649-Dota2Senate](src/LeetCode/0649-Dota2Senate/Solution.cs) |
| 1899 | [Merge Triplets to Form Target Triplet](https://leetcode.com/problems/merge-triplets-to-form-target-triplet/) | Medium | [1899-MergeTripletsToTarget](src/LeetCode/1899-MergeTripletsToTarget/Solution.cs) |
| 763 | [Partition Labels](https://leetcode.com/problems/partition-labels/) | Medium | [0763-PartitionLabels](src/LeetCode/0763-PartitionLabels/Solution.cs) |
| 678 | [Valid Parenthesis String](https://leetcode.com/problems/valid-parenthesis-string/) | Medium | [0678-ValidParenthesisString](src/LeetCode/0678-ValidParenthesisString/Solution.cs) |
| 135 | [Candy](https://leetcode.com/problems/candy/) | Hard | [0135-Candy](src/LeetCode/0135-Candy/Solution.cs) |

### Intervals

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 57 | [Insert Interval](https://leetcode.com/problems/insert-interval/) | Medium | [0057-InsertInterval](src/LeetCode/0057-InsertInterval/Solution.cs) |
| 56 | [Merge Intervals](https://leetcode.com/problems/merge-intervals/) | Medium | [0056-MergeIntervals](src/LeetCode/0056-MergeIntervals/Solution.cs) |
| 435 | [Non Overlapping Intervals](https://leetcode.com/problems/non-overlapping-intervals/) | Medium | [0435-NonOverlappingIntervals](src/LeetCode/0435-NonOverlappingIntervals/Solution.cs) |
| 252 | [Meeting Rooms](https://neetcode.io/problems/meeting-schedule/question) (NeetCode) | Easy | [0252-MeetingRooms](src/LeetCode/0252-MeetingRooms/Solution.cs) |
| 253 | [Meeting Rooms II](https://neetcode.io/problems/meeting-schedule-ii/question) (NeetCode) | Medium | [0253-MeetingRoomsII](src/LeetCode/0253-MeetingRoomsII/Solution.cs) |
| 2402 | [Meeting Rooms III](https://leetcode.com/problems/meeting-rooms-iii/) | Hard | [2402-MeetingRoomsIII](src/LeetCode/2402-MeetingRoomsIII/Solution.cs) |
| 1851 | [Minimum Interval to Include Each Query](https://leetcode.com/problems/minimum-interval-to-include-each-query/) | Hard | [1851-MinIntervalPerQuery](src/LeetCode/1851-MinIntervalPerQuery/Solution.cs) |

### Bit Manipulation

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 136 | [Single Number](https://leetcode.com/problems/single-number/) | Easy | [0136-SingleNumber](src/LeetCode/0136-SingleNumber/Solution.cs) |
| 191 | [Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/) | Easy | [0191-NumberOf1Bits](src/LeetCode/0191-NumberOf1Bits/Solution.cs) |
| 338 | [Counting Bits](https://leetcode.com/problems/counting-bits/) | Easy | [0338-CountingBits](src/LeetCode/0338-CountingBits/Solution.cs) |
| 67 | [Add Binary](https://leetcode.com/problems/add-binary/) | Easy | [0067-AddBinary](src/LeetCode/0067-AddBinary/Solution.cs) |
| 190 | [Reverse Bits](https://leetcode.com/problems/reverse-bits/) | Easy | [0190-ReverseBits](src/LeetCode/0190-ReverseBits/Solution.cs) |
| 268 | [Missing Number](https://leetcode.com/problems/missing-number/) | Easy | [0268-MissingNumber](src/LeetCode/0268-MissingNumber/Solution.cs) |
| 371 | [Sum of Two Integers](https://leetcode.com/problems/sum-of-two-integers/) | Medium | [0371-SumOfTwoIntegers](src/LeetCode/0371-SumOfTwoIntegers/Solution.cs) |
| 7 | [Reverse Integer](https://leetcode.com/problems/reverse-integer/) | Medium | [0007-ReverseInteger](src/LeetCode/0007-ReverseInteger/Solution.cs) |
| 201 | [Bitwise AND of Numbers Range](https://leetcode.com/problems/bitwise-and-of-numbers-range/) | Medium | [0201-BitwiseANDOfNumbersRange](src/LeetCode/0201-BitwiseANDOfNumbersRange/Solution.cs) |
| 3133 | [Minimum Array End](https://leetcode.com/problems/minimum-array-end/) | Medium | [3133-MinimumArrayEnd](src/LeetCode/3133-MinimumArrayEnd/Solution.cs) |

### Math & Geometry

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 168 | [Excel Sheet Column Title](https://leetcode.com/problems/excel-sheet-column-title/) | Easy | [0168-ExcelSheetColumnTitle](src/LeetCode/0168-ExcelSheetColumnTitle/Solution.cs) |
| 1071 | [Greatest Common Divisor of Strings](https://leetcode.com/problems/greatest-common-divisor-of-strings/) | Easy | [1071-GcdOfStrings](src/LeetCode/1071-GcdOfStrings/Solution.cs) |
| 2807 | [Insert Greatest Common Divisors in Linked List](https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/) | Medium | [2807-InsertGcdsInLinkedList](src/LeetCode/2807-InsertGcdsInLinkedList/Solution.cs) |
| 867 | [Transpose Matrix](https://leetcode.com/problems/transpose-matrix/) | Easy | [0867-TransposeMatrix](src/LeetCode/0867-TransposeMatrix/Solution.cs) |
| 48 | [Rotate Image](https://leetcode.com/problems/rotate-image/) | Medium | [0048-RotateImage](src/LeetCode/0048-RotateImage/Solution.cs) |
| 54 | [Spiral Matrix](https://leetcode.com/problems/spiral-matrix/) | Medium | [0054-SpiralMatrix](src/LeetCode/0054-SpiralMatrix/Solution.cs) |
| 73 | [Set Matrix Zeroes](https://leetcode.com/problems/set-matrix-zeroes/) | Medium | [0073-SetMatrixZeroes](src/LeetCode/0073-SetMatrixZeroes/Solution.cs) |
| 202 | [Happy Number](https://leetcode.com/problems/happy-number/) | Easy | [0202-HappyNumber](src/LeetCode/0202-HappyNumber/Solution.cs) |
| 66 | [Plus One](https://leetcode.com/problems/plus-one/) | Easy | [0066-PlusOne](src/LeetCode/0066-PlusOne/Solution.cs) |
| 13 | [Roman to Integer](https://leetcode.com/problems/roman-to-integer/) | Easy | [0013-RomanToInteger](src/LeetCode/0013-RomanToInteger/Solution.cs) |
| 50 | [Pow(x, n)](https://leetcode.com/problems/powx-n/) | Medium | [0050-PowXN](src/LeetCode/0050-PowXN/Solution.cs) |
| 43 | [Multiply Strings](https://leetcode.com/problems/multiply-strings/) | Medium | [0043-MultiplyStrings](src/LeetCode/0043-MultiplyStrings/Solution.cs) |
| 2013 | [Detect Squares](https://leetcode.com/problems/detect-squares/) | Medium | [2013-DetectSquares](src/LeetCode/2013-DetectSquares/Solution.cs) |

### Extra (NeetCode course)

| LC # | Problem | Difficulty | Project |
|---|---|---|---|
| 485 | [Max Consecutive Ones](https://leetcode.com/problems/max-consecutive-ones/) | Easy | [0485-MaxConsecutiveOnes](src/LeetCode/0485-MaxConsecutiveOnes/Solution.cs) |
| 1299 | [Replace Elements with Greatest Element on Right Side](https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/) | Easy | [1299-ReplaceElements](src/LeetCode/1299-ReplaceElements/Solution.cs) |

