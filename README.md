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

## Arrays & Hashing

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 001 | [Concatenation of Array](https://leetcode.com/problems/concatenation-of-array/) | Easy | 1929 | [001-ConcatenationOfArray](src/01-ArraysHashing/001-ConcatenationOfArray/Solution.cs) |
| 002 | [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/) | Easy | 217 | [002-ContainsDuplicate](src/01-ArraysHashing/002-ContainsDuplicate/Solution.cs) |
| 003 | [Valid Anagram](https://leetcode.com/problems/valid-anagram/) | Easy | 242 | [003-ValidAnagram](src/01-ArraysHashing/003-ValidAnagram/Solution.cs) |
| 004 | [Two Sum](https://leetcode.com/problems/two-sum/) | Easy | 1 | [004-TwoSum](src/01-ArraysHashing/004-TwoSum/Solution.cs) |
| 005 | [Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/) | Easy | 14 | [005-LongestCommonPrefix](src/01-ArraysHashing/005-LongestCommonPrefix/Solution.cs) |
| 006 | [Group Anagrams](https://leetcode.com/problems/group-anagrams/) | Medium | 49 | [006-GroupAnagrams](src/01-ArraysHashing/006-GroupAnagrams/Solution.cs) |
| 007 | [Remove Element](https://leetcode.com/problems/remove-element/) | Easy | 27 | [007-RemoveElement](src/01-ArraysHashing/007-RemoveElement/Solution.cs) |
| 008 | [Majority Element](https://leetcode.com/problems/majority-element/) | Easy | 169 | [008-MajorityElement](src/01-ArraysHashing/008-MajorityElement/Solution.cs) |
| 009 | [Design HashSet](https://leetcode.com/problems/design-hashset/) | Easy | 705 | [009-DesignHashSet](src/01-ArraysHashing/009-DesignHashSet/Solution.cs) |
| 010 | [Design HashMap](https://leetcode.com/problems/design-hashmap/) | Easy | 706 | [010-DesignHashMap](src/01-ArraysHashing/010-DesignHashMap/Solution.cs) |
| 011 | [Sort an Array](https://leetcode.com/problems/sort-an-array/) | Medium | 912 | [011-SortAnArray](src/01-ArraysHashing/011-SortAnArray/Solution.cs) |
| 012 | [Sort Colors](https://leetcode.com/problems/sort-colors/) | Medium | 75 | [012-SortColors](src/01-ArraysHashing/012-SortColors/Solution.cs) |
| 013 | [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | Medium | 347 | [013-TopKFrequentElements](src/01-ArraysHashing/013-TopKFrequentElements/Solution.cs) |
| 014 | [Encode and Decode Strings](https://neetcode.io/problems/string-encode-and-decode/question) (NeetCode) | Medium | 271 | [014-EncodeAndDecodeStrings](src/01-ArraysHashing/014-EncodeAndDecodeStrings/Solution.cs) |
| 015 | [Range Sum Query 2D Immutable](https://leetcode.com/problems/range-sum-query-2d-immutable/) | Medium | 304 | [015-RangeSumQuery2DImmutable](src/01-ArraysHashing/015-RangeSumQuery2DImmutable/Solution.cs) |
| 016 | [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) | Medium | 238 | [016-ProductOfArrayExceptSelf](src/01-ArraysHashing/016-ProductOfArrayExceptSelf/Solution.cs) |
| 017 | [Valid Sudoku](https://leetcode.com/problems/valid-sudoku/) | Medium | 36 | [017-ValidSudoku](src/01-ArraysHashing/017-ValidSudoku/Solution.cs) |
| 018 | [Longest Consecutive Sequence](https://leetcode.com/problems/longest-consecutive-sequence/) | Medium | 128 | [018-LongestConsecutiveSequence](src/01-ArraysHashing/018-LongestConsecutiveSequence/Solution.cs) |
| 019 | [Best Time to Buy And Sell Stock II](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/) | Medium | 122 | [019-BestTimeToBuyAndSellStockII](src/01-ArraysHashing/019-BestTimeToBuyAndSellStockII/Solution.cs) |
| 020 | [Majority Element II](https://leetcode.com/problems/majority-element-ii/) | Medium | 229 | [020-MajorityElementII](src/01-ArraysHashing/020-MajorityElementII/Solution.cs) |
| 021 | [Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/) | Medium | 560 | [021-SubarraySumEqualsK](src/01-ArraysHashing/021-SubarraySumEqualsK/Solution.cs) |
| 022 | [First Missing Positive](https://leetcode.com/problems/first-missing-positive/) | Hard | 41 | [022-FirstMissingPositive](src/01-ArraysHashing/022-FirstMissingPositive/Solution.cs) |

## Two Pointers

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 023 | [Reverse String](https://leetcode.com/problems/reverse-string/) | Easy | 344 | [023-ReverseString](src/02-TwoPointers/023-ReverseString/Solution.cs) |
| 024 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | Easy | 125 | [024-ValidPalindrome](src/02-TwoPointers/024-ValidPalindrome/Solution.cs) |
| 025 | [Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/) | Easy | 680 | [025-ValidPalindromeII](src/02-TwoPointers/025-ValidPalindromeII/Solution.cs) |
| 026 | [Merge Strings Alternately](https://leetcode.com/problems/merge-strings-alternately/) | Easy | 1768 | [026-MergeStringsAlternately](src/02-TwoPointers/026-MergeStringsAlternately/Solution.cs) |
| 027 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | Easy | 88 | [027-MergeSortedArray](src/02-TwoPointers/027-MergeSortedArray/Solution.cs) |
| 028 | [Remove Duplicates From Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) | Easy | 26 | [028-RemoveDuplicatesFromSortedArray](src/02-TwoPointers/028-RemoveDuplicatesFromSortedArray/Solution.cs) |
| 029 | [Two Sum II Input Array Is Sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) | Medium | 167 | [029-TwoSumIIInputArrayIsSorted](src/02-TwoPointers/029-TwoSumIIInputArrayIsSorted/Solution.cs) |
| 030 | [3Sum](https://leetcode.com/problems/3sum/) | Medium | 15 | [030-3Sum](src/02-TwoPointers/030-3Sum/Solution.cs) |
| 031 | [4Sum](https://leetcode.com/problems/4sum/) | Medium | 18 | [031-4Sum](src/02-TwoPointers/031-4Sum/Solution.cs) |
| 032 | [Rotate Array](https://leetcode.com/problems/rotate-array/) | Medium | 189 | [032-RotateArray](src/02-TwoPointers/032-RotateArray/Solution.cs) |
| 033 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | Medium | 11 | [033-ContainerWithMostWater](src/02-TwoPointers/033-ContainerWithMostWater/Solution.cs) |
| 034 | [Boats to Save People](https://leetcode.com/problems/boats-to-save-people/) | Medium | 881 | [034-BoatsToSavePeople](src/02-TwoPointers/034-BoatsToSavePeople/Solution.cs) |
| 035 | [Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water/) | Hard | 42 | [035-TrappingRainWater](src/02-TwoPointers/035-TrappingRainWater/Solution.cs) |

## Sliding Window

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 036 | [Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii/) | Easy | 219 | [036-ContainsDuplicateII](src/03-SlidingWindow/036-ContainsDuplicateII/Solution.cs) |
| 037 | [Best Time to Buy And Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | Easy | 121 | [037-BestTimeToBuyAndSellStock](src/03-SlidingWindow/037-BestTimeToBuyAndSellStock/Solution.cs) |
| 038 | [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | Medium | 3 | [038-LongestSubstringWithoutRepeatingCharacters](src/03-SlidingWindow/038-LongestSubstringWithoutRepeatingCharacters/Solution.cs) |
| 039 | [Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/) | Medium | 424 | [039-LongestRepeatingCharacterReplacement](src/03-SlidingWindow/039-LongestRepeatingCharacterReplacement/Solution.cs) |
| 040 | [Permutation In String](https://leetcode.com/problems/permutation-in-string/) | Medium | 567 | [040-PermutationInString](src/03-SlidingWindow/040-PermutationInString/Solution.cs) |
| 041 | [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/) | Medium | 209 | [041-MinimumSizeSubarraySum](src/03-SlidingWindow/041-MinimumSizeSubarraySum/Solution.cs) |
| 042 | [Find K Closest Elements](https://leetcode.com/problems/find-k-closest-elements/) | Medium | 658 | [042-FindKClosestElements](src/03-SlidingWindow/042-FindKClosestElements/Solution.cs) |
| 043 | [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/) | Hard | 76 | [043-MinimumWindowSubstring](src/03-SlidingWindow/043-MinimumWindowSubstring/Solution.cs) |
| 044 | [Sliding Window Maximum](https://leetcode.com/problems/sliding-window-maximum/) | Hard | 239 | [044-SlidingWindowMaximum](src/03-SlidingWindow/044-SlidingWindowMaximum/Solution.cs) |

## Binary Search

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 045 | [Binary Search](https://leetcode.com/problems/binary-search/) | Easy | 704 | [045-BinarySearch](src/04-BinarySearch/045-BinarySearch/Solution.cs) |
| 046 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | Easy | 35 | [046-SearchInsertPosition](src/04-BinarySearch/046-SearchInsertPosition/Solution.cs) |
| 047 | [Guess Number Higher Or Lower](https://leetcode.com/problems/guess-number-higher-or-lower/) | Easy | 374 | [047-GuessNumberHigherOrLower](src/04-BinarySearch/047-GuessNumberHigherOrLower/Solution.cs) |
| 048 | [Sqrt(x)](https://leetcode.com/problems/sqrtx/) | Easy | 69 | [048-SqrtX](src/04-BinarySearch/048-SqrtX/Solution.cs) |
| 049 | [Search a 2D Matrix](https://leetcode.com/problems/search-a-2d-matrix/) | Medium | 74 | [049-SearchA2DMatrix](src/04-BinarySearch/049-SearchA2DMatrix/Solution.cs) |
| 050 | [Koko Eating Bananas](https://leetcode.com/problems/koko-eating-bananas/) | Medium | 875 | [050-KokoEatingBananas](src/04-BinarySearch/050-KokoEatingBananas/Solution.cs) |
| 051 | [Capacity to Ship Packages Within D Days](https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/) | Medium | 1011 | [051-CapacityToShipPackagesWithinDDays](src/04-BinarySearch/051-CapacityToShipPackagesWithinDDays/Solution.cs) |
| 052 | [Find Minimum In Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/) | Medium | 153 | [052-FindMinimumInRotatedSortedArray](src/04-BinarySearch/052-FindMinimumInRotatedSortedArray/Solution.cs) |
| 053 | [Search In Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | Medium | 33 | [053-SearchInRotatedSortedArray](src/04-BinarySearch/053-SearchInRotatedSortedArray/Solution.cs) |
| 054 | [Search In Rotated Sorted Array II](https://leetcode.com/problems/search-in-rotated-sorted-array-ii/) | Medium | 81 | [054-SearchInRotatedSortedArrayII](src/04-BinarySearch/054-SearchInRotatedSortedArrayII/Solution.cs) |
| 055 | [Time Based Key Value Store](https://leetcode.com/problems/time-based-key-value-store/) | Medium | 981 | [055-TimeBasedKeyValueStore](src/04-BinarySearch/055-TimeBasedKeyValueStore/Solution.cs) |
| 056 | [Split Array Largest Sum](https://leetcode.com/problems/split-array-largest-sum/) | Hard | 410 | [056-SplitArrayLargestSum](src/04-BinarySearch/056-SplitArrayLargestSum/Solution.cs) |
| 057 | [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/) | Hard | 4 | [057-MedianOfTwoSortedArrays](src/04-BinarySearch/057-MedianOfTwoSortedArrays/Solution.cs) |
| 058 | [Find in Mountain Array](https://leetcode.com/problems/find-in-mountain-array/) | Hard | 1095 | [058-FindInMountainArray](src/04-BinarySearch/058-FindInMountainArray/Solution.cs) |

## Linked List

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 059 | [Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/) | Easy | 206 | [059-ReverseLinkedList](src/05-LinkedList/059-ReverseLinkedList/Solution.cs) |
| 060 | [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/) | Easy | 21 | [060-MergeTwoSortedLists](src/05-LinkedList/060-MergeTwoSortedLists/Solution.cs) |
| 061 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | Easy | 141 | [061-LinkedListCycle](src/05-LinkedList/061-LinkedListCycle/Solution.cs) |
| 062 | [Reorder List](https://leetcode.com/problems/reorder-list/) | Medium | 143 | [062-ReorderList](src/05-LinkedList/062-ReorderList/Solution.cs) |
| 063 | [Remove Nth Node From End of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/) | Medium | 19 | [063-RemoveNthNodeFromEndOfList](src/05-LinkedList/063-RemoveNthNodeFromEndOfList/Solution.cs) |
| 064 | [Copy List With Random Pointer](https://leetcode.com/problems/copy-list-with-random-pointer/) | Medium | 138 | [064-CopyListWithRandomPointer](src/05-LinkedList/064-CopyListWithRandomPointer/Solution.cs) |
| 065 | [Add Two Numbers](https://leetcode.com/problems/add-two-numbers/) | Medium | 2 | [065-AddTwoNumbers](src/05-LinkedList/065-AddTwoNumbers/Solution.cs) |
| 066 | [Find The Duplicate Number](https://leetcode.com/problems/find-the-duplicate-number/) | Medium | 287 | [066-FindTheDuplicateNumber](src/05-LinkedList/066-FindTheDuplicateNumber/Solution.cs) |
| 067 | [Reverse Linked List II](https://leetcode.com/problems/reverse-linked-list-ii/) | Medium | 92 | [067-ReverseLinkedListII](src/05-LinkedList/067-ReverseLinkedListII/Solution.cs) |
| 068 | [Design Circular Queue](https://leetcode.com/problems/design-circular-queue/) | Medium | 622 | [068-DesignCircularQueue](src/05-LinkedList/068-DesignCircularQueue/Solution.cs) |
| 069 | [LRU Cache](https://leetcode.com/problems/lru-cache/) | Medium | 146 | [069-LRUCache](src/05-LinkedList/069-LRUCache/Solution.cs) |
| 070 | [LFU Cache](https://leetcode.com/problems/lfu-cache/) | Hard | 460 | [070-LFUCache](src/05-LinkedList/070-LFUCache/Solution.cs) |
| 071 | [Merge K Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/) | Hard | 23 | [071-MergeKSortedLists](src/05-LinkedList/071-MergeKSortedLists/Solution.cs) |
| 072 | [Reverse Nodes In K Group](https://leetcode.com/problems/reverse-nodes-in-k-group/) | Hard | 25 | [072-ReverseNodesInKGroup](src/05-LinkedList/072-ReverseNodesInKGroup/Solution.cs) |

## Stack

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 073 | [Baseball Game](https://leetcode.com/problems/baseball-game/) | Easy | 682 | [073-BaseballGame](src/06-Stack/073-BaseballGame/Solution.cs) |
| 074 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | Easy | 20 | [074-ValidParentheses](src/06-Stack/074-ValidParentheses/Solution.cs) |
| 075 | [Implement Stack Using Queues](https://leetcode.com/problems/implement-stack-using-queues/) | Easy | 225 | [075-ImplementStackUsingQueues](src/06-Stack/075-ImplementStackUsingQueues/Solution.cs) |
| 076 | [Implement Queue using Stacks](https://leetcode.com/problems/implement-queue-using-stacks/) | Easy | 232 | [076-ImplementQueueUsingStacks](src/06-Stack/076-ImplementQueueUsingStacks/Solution.cs) |
| 077 | [Min Stack](https://leetcode.com/problems/min-stack/) | Medium | 155 | [077-MinStack](src/06-Stack/077-MinStack/Solution.cs) |
| 078 | [Evaluate Reverse Polish Notation](https://leetcode.com/problems/evaluate-reverse-polish-notation/) | Medium | 150 | [078-EvaluateReversePolishNotation](src/06-Stack/078-EvaluateReversePolishNotation/Solution.cs) |
| 079 | [Asteroid Collision](https://leetcode.com/problems/asteroid-collision/) | Medium | 735 | [079-AsteroidCollision](src/06-Stack/079-AsteroidCollision/Solution.cs) |
| 080 | [Daily Temperatures](https://leetcode.com/problems/daily-temperatures/) | Medium | 739 | [080-DailyTemperatures](src/06-Stack/080-DailyTemperatures/Solution.cs) |
| 081 | [Online Stock Span](https://leetcode.com/problems/online-stock-span/) | Medium | 901 | [081-OnlineStockSpan](src/06-Stack/081-OnlineStockSpan/Solution.cs) |
| 082 | [Car Fleet](https://leetcode.com/problems/car-fleet/) | Medium | 853 | [082-CarFleet](src/06-Stack/082-CarFleet/Solution.cs) |
| 083 | [Simplify Path](https://leetcode.com/problems/simplify-path/) | Medium | 71 | [083-SimplifyPath](src/06-Stack/083-SimplifyPath/Solution.cs) |
| 084 | [Decode String](https://leetcode.com/problems/decode-string/) | Medium | 394 | [084-DecodeString](src/06-Stack/084-DecodeString/Solution.cs) |
| 085 | [Maximum Frequency Stack](https://leetcode.com/problems/maximum-frequency-stack/) | Hard | 895 | [085-MaximumFrequencyStack](src/06-Stack/085-MaximumFrequencyStack/Solution.cs) |
| 086 | [Largest Rectangle In Histogram](https://leetcode.com/problems/largest-rectangle-in-histogram/) | Hard | 84 | [086-LargestRectangleInHistogram](src/06-Stack/086-LargestRectangleInHistogram/Solution.cs) |

## Trees

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 087 | [Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/) | Easy | 94 | [087-BinaryTreeInorderTraversal](src/07-Trees/087-BinaryTreeInorderTraversal/Solution.cs) |
| 088 | [Binary Tree Preorder Traversal](https://leetcode.com/problems/binary-tree-preorder-traversal/) | Easy | 144 | [088-BinaryTreePreorderTraversal](src/07-Trees/088-BinaryTreePreorderTraversal/Solution.cs) |
| 089 | [Binary Tree Postorder Traversal](https://leetcode.com/problems/binary-tree-postorder-traversal/) | Easy | 145 | [089-BinaryTreePostorderTraversal](src/07-Trees/089-BinaryTreePostorderTraversal/Solution.cs) |
| 090 | [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/) | Easy | 226 | [090-InvertBinaryTree](src/07-Trees/090-InvertBinaryTree/Solution.cs) |
| 091 | [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/) | Easy | 104 | [091-MaximumDepthOfBinaryTree](src/07-Trees/091-MaximumDepthOfBinaryTree/Solution.cs) |
| 092 | [Diameter of Binary Tree](https://leetcode.com/problems/diameter-of-binary-tree/) | Easy | 543 | [092-DiameterOfBinaryTree](src/07-Trees/092-DiameterOfBinaryTree/Solution.cs) |
| 093 | [Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree/) | Easy | 110 | [093-BalancedBinaryTree](src/07-Trees/093-BalancedBinaryTree/Solution.cs) |
| 094 | [Same Tree](https://leetcode.com/problems/same-tree/) | Easy | 100 | [094-SameTree](src/07-Trees/094-SameTree/Solution.cs) |
| 095 | [Subtree of Another Tree](https://leetcode.com/problems/subtree-of-another-tree/) | Easy | 572 | [095-SubtreeOfAnotherTree](src/07-Trees/095-SubtreeOfAnotherTree/Solution.cs) |
| 096 | [Lowest Common Ancestor of a Binary Search Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/) | Medium | 235 | [096-LowestCommonAncestorOfABinarySearchTree](src/07-Trees/096-LowestCommonAncestorOfABinarySearchTree/Solution.cs) |
| 097 | [Insert into a Binary Search Tree](https://leetcode.com/problems/insert-into-a-binary-search-tree/) | Medium | 701 | [097-InsertIntoABinarySearchTree](src/07-Trees/097-InsertIntoABinarySearchTree/Solution.cs) |
| 098 | [Delete Node in a BST](https://leetcode.com/problems/delete-node-in-a-bst/) | Medium | 450 | [098-DeleteNodeInABST](src/07-Trees/098-DeleteNodeInABST/Solution.cs) |
| 099 | [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/) | Medium | 102 | [099-BinaryTreeLevelOrderTraversal](src/07-Trees/099-BinaryTreeLevelOrderTraversal/Solution.cs) |
| 100 | [Binary Tree Right Side View](https://leetcode.com/problems/binary-tree-right-side-view/) | Medium | 199 | [100-BinaryTreeRightSideView](src/07-Trees/100-BinaryTreeRightSideView/Solution.cs) |
| 101 | [Construct Quad Tree](https://leetcode.com/problems/construct-quad-tree/) | Medium | 427 | [101-ConstructQuadTree](src/07-Trees/101-ConstructQuadTree/Solution.cs) |
| 102 | [Count Good Nodes In Binary Tree](https://leetcode.com/problems/count-good-nodes-in-binary-tree/) | Medium | 1448 | [102-CountGoodNodesInBinaryTree](src/07-Trees/102-CountGoodNodesInBinaryTree/Solution.cs) |
| 103 | [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/) | Medium | 98 | [103-ValidateBinarySearchTree](src/07-Trees/103-ValidateBinarySearchTree/Solution.cs) |
| 104 | [Kth Smallest Element In a Bst](https://leetcode.com/problems/kth-smallest-element-in-a-bst/) | Medium | 230 | [104-KthSmallestElementInABst](src/07-Trees/104-KthSmallestElementInABst/Solution.cs) |
| 105 | [Construct Binary Tree From Preorder And Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/) | Medium | 105 | [105-ConstructBinaryTreeFromPreorderAndInorderTraversal](src/07-Trees/105-ConstructBinaryTreeFromPreorderAndInorderTraversal/Solution.cs) |
| 106 | [House Robber III](https://leetcode.com/problems/house-robber-iii/) | Medium | 337 | [106-HouseRobberIII](src/07-Trees/106-HouseRobberIII/Solution.cs) |
| 107 | [Delete Leaves With a Given Value](https://leetcode.com/problems/delete-leaves-with-a-given-value/) | Medium | 1325 | [107-DeleteLeavesWithAGivenValue](src/07-Trees/107-DeleteLeavesWithAGivenValue/Solution.cs) |
| 108 | [Binary Tree Maximum Path Sum](https://leetcode.com/problems/binary-tree-maximum-path-sum/) | Hard | 124 | [108-BinaryTreeMaximumPathSum](src/07-Trees/108-BinaryTreeMaximumPathSum/Solution.cs) |
| 109 | [Serialize And Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/) | Hard | 297 | [109-SerializeAndDeserializeBinaryTree](src/07-Trees/109-SerializeAndDeserializeBinaryTree/Solution.cs) |

## Tries

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 110 | [Implement Trie Prefix Tree](https://leetcode.com/problems/implement-trie-prefix-tree/) | Medium | 208 | [110-ImplementTriePrefixTree](src/08-Tries/110-ImplementTriePrefixTree/Solution.cs) |
| 111 | [Design Add And Search Words Data Structure](https://leetcode.com/problems/design-add-and-search-words-data-structure/) | Medium | 211 | [111-DesignAddAndSearchWordsDataStructure](src/08-Tries/111-DesignAddAndSearchWordsDataStructure/Solution.cs) |
| 112 | [Extra Characters in a String](https://leetcode.com/problems/extra-characters-in-a-string/) | Medium | 2707 | [112-ExtraCharactersInAString](src/08-Tries/112-ExtraCharactersInAString/Solution.cs) |
| 113 | [Word Search II](https://leetcode.com/problems/word-search-ii/) | Hard | 212 | [113-WordSearchII](src/08-Tries/113-WordSearchII/Solution.cs) |

## Backtracking

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 114 | [Sum of All Subsets XOR Total](https://leetcode.com/problems/sum-of-all-subset-xor-totals/) | Easy | 1863 | [114-SumOfAllSubsetsXORTotal](src/09-Backtracking/114-SumOfAllSubsetsXORTotal/Solution.cs) |
| 115 | [Subsets](https://leetcode.com/problems/subsets/) | Medium | 78 | [115-Subsets](src/09-Backtracking/115-Subsets/Solution.cs) |
| 116 | [Combination Sum](https://leetcode.com/problems/combination-sum/) | Medium | 39 | [116-CombinationSum](src/09-Backtracking/116-CombinationSum/Solution.cs) |
| 117 | [Combination Sum II](https://leetcode.com/problems/combination-sum-ii/) | Medium | 40 | [117-CombinationSumII](src/09-Backtracking/117-CombinationSumII/Solution.cs) |
| 118 | [Combinations](https://leetcode.com/problems/combinations/) | Medium | 77 | [118-Combinations](src/09-Backtracking/118-Combinations/Solution.cs) |
| 119 | [Permutations](https://leetcode.com/problems/permutations/) | Medium | 46 | [119-Permutations](src/09-Backtracking/119-Permutations/Solution.cs) |
| 120 | [Subsets II](https://leetcode.com/problems/subsets-ii/) | Medium | 90 | [120-SubsetsII](src/09-Backtracking/120-SubsetsII/Solution.cs) |
| 121 | [Permutations II](https://leetcode.com/problems/permutations-ii/) | Medium | 47 | [121-PermutationsII](src/09-Backtracking/121-PermutationsII/Solution.cs) |
| 122 | [Generate Parentheses](https://leetcode.com/problems/generate-parentheses/) | Medium | 22 | [122-GenerateParentheses](src/09-Backtracking/122-GenerateParentheses/Solution.cs) |
| 123 | [Word Search](https://leetcode.com/problems/word-search/) | Medium | 79 | [123-WordSearch](src/09-Backtracking/123-WordSearch/Solution.cs) |
| 124 | [Palindrome Partitioning](https://leetcode.com/problems/palindrome-partitioning/) | Medium | 131 | [124-PalindromePartitioning](src/09-Backtracking/124-PalindromePartitioning/Solution.cs) |
| 125 | [Letter Combinations of a Phone Number](https://leetcode.com/problems/letter-combinations-of-a-phone-number/) | Medium | 17 | [125-LetterCombinationsOfAPhoneNumber](src/09-Backtracking/125-LetterCombinationsOfAPhoneNumber/Solution.cs) |
| 126 | [Matchsticks to Square](https://leetcode.com/problems/matchsticks-to-square/) | Medium | 473 | [126-MatchsticksToSquare](src/09-Backtracking/126-MatchsticksToSquare/Solution.cs) |
| 127 | [Partition to K Equal Sum Subsets](https://leetcode.com/problems/partition-to-k-equal-sum-subsets/) | Medium | 698 | [127-PartitionToKEqualSumSubsets](src/09-Backtracking/127-PartitionToKEqualSumSubsets/Solution.cs) |
| 128 | [N Queens](https://leetcode.com/problems/n-queens/) | Hard | 51 | [128-NQueens](src/09-Backtracking/128-NQueens/Solution.cs) |
| 129 | [N Queens II](https://leetcode.com/problems/n-queens-ii/) | Hard | 52 | [129-NQueensII](src/09-Backtracking/129-NQueensII/Solution.cs) |
| 130 | [Word Break II](https://leetcode.com/problems/word-break-ii/) | Hard | 140 | [130-WordBreakII](src/09-Backtracking/130-WordBreakII/Solution.cs) |

## Heap / Priority Queue

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 131 | [Kth Largest Element In a Stream](https://leetcode.com/problems/kth-largest-element-in-a-stream/) | Easy | 703 | [131-KthLargestElementInAStream](src/10-HeapPriorityQueue/131-KthLargestElementInAStream/Solution.cs) |
| 132 | [Last Stone Weight](https://leetcode.com/problems/last-stone-weight/) | Easy | 1046 | [132-LastStoneWeight](src/10-HeapPriorityQueue/132-LastStoneWeight/Solution.cs) |
| 133 | [K Closest Points to Origin](https://leetcode.com/problems/k-closest-points-to-origin/) | Medium | 973 | [133-KClosestPointsToOrigin](src/10-HeapPriorityQueue/133-KClosestPointsToOrigin/Solution.cs) |
| 134 | [Kth Largest Element In An Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | Medium | 215 | [134-KthLargestElementInAnArray](src/10-HeapPriorityQueue/134-KthLargestElementInAnArray/Solution.cs) |
| 135 | [Task Scheduler](https://leetcode.com/problems/task-scheduler/) | Medium | 621 | [135-TaskScheduler](src/10-HeapPriorityQueue/135-TaskScheduler/Solution.cs) |
| 136 | [Design Twitter](https://leetcode.com/problems/design-twitter/) | Medium | 355 | [136-DesignTwitter](src/10-HeapPriorityQueue/136-DesignTwitter/Solution.cs) |
| 137 | [Single Threaded CPU](https://leetcode.com/problems/single-threaded-cpu/) | Medium | 1834 | [137-SingleThreadedCPU](src/10-HeapPriorityQueue/137-SingleThreadedCPU/Solution.cs) |
| 138 | [Reorganize String](https://leetcode.com/problems/reorganize-string/) | Medium | 767 | [138-ReorganizeString](src/10-HeapPriorityQueue/138-ReorganizeString/Solution.cs) |
| 139 | [Longest Happy String](https://leetcode.com/problems/longest-happy-string/) | Medium | 1405 | [139-LongestHappyString](src/10-HeapPriorityQueue/139-LongestHappyString/Solution.cs) |
| 140 | [Car Pooling](https://leetcode.com/problems/car-pooling/) | Medium | 1094 | [140-CarPooling](src/10-HeapPriorityQueue/140-CarPooling/Solution.cs) |
| 141 | [Find Median From Data Stream](https://leetcode.com/problems/find-median-from-data-stream/) | Hard | 295 | [141-FindMedianFromDataStream](src/10-HeapPriorityQueue/141-FindMedianFromDataStream/Solution.cs) |
| 142 | [IPO](https://leetcode.com/problems/ipo/) | Hard | 502 | [142-IPO](src/10-HeapPriorityQueue/142-IPO/Solution.cs) |

## Graphs

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 143 | [Island Perimeter](https://leetcode.com/problems/island-perimeter/) | Easy | 463 | [143-IslandPerimeter](src/11-Graphs/143-IslandPerimeter/Solution.cs) |
| 144 | [Verifying An Alien Dictionary](https://leetcode.com/problems/verifying-an-alien-dictionary/) | Easy | 953 | [144-VerifyingAnAlienDictionary](src/11-Graphs/144-VerifyingAnAlienDictionary/Solution.cs) |
| 145 | [Find the Town Judge](https://leetcode.com/problems/find-the-town-judge/) | Easy | 997 | [145-FindTheTownJudge](src/11-Graphs/145-FindTheTownJudge/Solution.cs) |
| 146 | [Number of Islands](https://leetcode.com/problems/number-of-islands/) | Medium | 200 | [146-NumberOfIslands](src/11-Graphs/146-NumberOfIslands/Solution.cs) |
| 147 | [Max Area of Island](https://leetcode.com/problems/max-area-of-island/) | Medium | 695 | [147-MaxAreaOfIsland](src/11-Graphs/147-MaxAreaOfIsland/Solution.cs) |
| 148 | [Clone Graph](https://leetcode.com/problems/clone-graph/) | Medium | 133 | [148-CloneGraph](src/11-Graphs/148-CloneGraph/Solution.cs) |
| 149 | [Walls And Gates](https://neetcode.io/problems/islands-and-treasure/question) (NeetCode) | Medium | 286 | [149-WallsAndGates](src/11-Graphs/149-WallsAndGates/Solution.cs) |
| 150 | [Rotting Oranges](https://leetcode.com/problems/rotting-oranges/) | Medium | 994 | [150-RottingOranges](src/11-Graphs/150-RottingOranges/Solution.cs) |
| 151 | [Pacific Atlantic Water Flow](https://leetcode.com/problems/pacific-atlantic-water-flow/) | Medium | 417 | [151-PacificAtlanticWaterFlow](src/11-Graphs/151-PacificAtlanticWaterFlow/Solution.cs) |
| 152 | [Surrounded Regions](https://leetcode.com/problems/surrounded-regions/) | Medium | 130 | [152-SurroundedRegions](src/11-Graphs/152-SurroundedRegions/Solution.cs) |
| 153 | [Open The Lock](https://leetcode.com/problems/open-the-lock/) | Medium | 752 | [153-OpenTheLock](src/11-Graphs/153-OpenTheLock/Solution.cs) |
| 154 | [Course Schedule](https://leetcode.com/problems/course-schedule/) | Medium | 207 | [154-CourseSchedule](src/11-Graphs/154-CourseSchedule/Solution.cs) |
| 155 | [Course Schedule II](https://leetcode.com/problems/course-schedule-ii/) | Medium | 210 | [155-CourseScheduleII](src/11-Graphs/155-CourseScheduleII/Solution.cs) |
| 156 | [Graph Valid Tree](https://neetcode.io/problems/valid-tree/question) (NeetCode) | Medium | 261 | [156-GraphValidTree](src/11-Graphs/156-GraphValidTree/Solution.cs) |
| 157 | [Course Schedule IV](https://leetcode.com/problems/course-schedule-iv/) | Medium | 1462 | [157-CourseScheduleIV](src/11-Graphs/157-CourseScheduleIV/Solution.cs) |
| 158 | [Number of Connected Components In An Undirected Graph](https://neetcode.io/problems/count-connected-components/question) (NeetCode) | Medium | 323 | [158-NumberOfConnectedComponentsInAnUndirectedGraph](src/11-Graphs/158-NumberOfConnectedComponentsInAnUndirectedGraph/Solution.cs) |
| 159 | [Redundant Connection](https://leetcode.com/problems/redundant-connection/) | Medium | 684 | [159-RedundantConnection](src/11-Graphs/159-RedundantConnection/Solution.cs) |
| 160 | [Accounts Merge](https://leetcode.com/problems/accounts-merge/) | Medium | 721 | [160-AccountsMerge](src/11-Graphs/160-AccountsMerge/Solution.cs) |
| 161 | [Evaluate Division](https://leetcode.com/problems/evaluate-division/) | Medium | 399 | [161-EvaluateDivision](src/11-Graphs/161-EvaluateDivision/Solution.cs) |
| 162 | [Minimum Height Trees](https://leetcode.com/problems/minimum-height-trees/) | Medium | 310 | [162-MinimumHeightTrees](src/11-Graphs/162-MinimumHeightTrees/Solution.cs) |
| 163 | [Word Ladder](https://leetcode.com/problems/word-ladder/) | Hard | 127 | [163-WordLadder](src/11-Graphs/163-WordLadder/Solution.cs) |

## Advanced Graphs

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 164 | [Path with Minimum Effort](https://leetcode.com/problems/path-with-minimum-effort/) | Medium | 1631 | [164-PathWithMinimumEffort](src/12-AdvancedGraphs/164-PathWithMinimumEffort/Solution.cs) |
| 165 | [Network Delay Time](https://leetcode.com/problems/network-delay-time/) | Medium | 743 | [165-NetworkDelayTime](src/12-AdvancedGraphs/165-NetworkDelayTime/Solution.cs) |
| 166 | [Reconstruct Itinerary](https://leetcode.com/problems/reconstruct-itinerary/) | Hard | 332 | [166-ReconstructItinerary](src/12-AdvancedGraphs/166-ReconstructItinerary/Solution.cs) |
| 167 | [Min Cost to Connect All Points](https://leetcode.com/problems/min-cost-to-connect-all-points/) | Medium | 1584 | [167-MinCostToConnectAllPoints](src/12-AdvancedGraphs/167-MinCostToConnectAllPoints/Solution.cs) |
| 168 | [Swim In Rising Water](https://leetcode.com/problems/swim-in-rising-water/) | Hard | 778 | [168-SwimInRisingWater](src/12-AdvancedGraphs/168-SwimInRisingWater/Solution.cs) |
| 169 | [Alien Dictionary](https://neetcode.io/problems/foreign-dictionary/question) (NeetCode) | Hard | 269 | [169-AlienDictionary](src/12-AdvancedGraphs/169-AlienDictionary/Solution.cs) |
| 170 | [Cheapest Flights Within K Stops](https://leetcode.com/problems/cheapest-flights-within-k-stops/) | Medium | 787 | [170-CheapestFlightsWithinKStops](src/12-AdvancedGraphs/170-CheapestFlightsWithinKStops/Solution.cs) |
| 171 | [Find Critical and Pseudo Critical Edges in Minimum Spanning Tree](https://leetcode.com/problems/find-critical-and-pseudo-critical-edges-in-minimum-spanning-tree/) | Hard | 1489 | [171-FindCriticalAndPseudoCriticalEdgesInMinimumSpanningTree](src/12-AdvancedGraphs/171-FindCriticalAndPseudoCriticalEdgesInMinimumSpanningTree/Solution.cs) |
| 172 | [Build a Matrix With Conditions](https://leetcode.com/problems/build-a-matrix-with-conditions/) | Hard | 2392 | [172-BuildAMatrixWithConditions](src/12-AdvancedGraphs/172-BuildAMatrixWithConditions/Solution.cs) |
| 173 | [Greatest Common Divisor Traversal](https://leetcode.com/problems/greatest-common-divisor-traversal/) | Hard | 2709 | [173-GreatestCommonDivisorTraversal](src/12-AdvancedGraphs/173-GreatestCommonDivisorTraversal/Solution.cs) |

## 1-D Dynamic Programming

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 174 | [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/) | Easy | 70 | [174-ClimbingStairs](src/13-1DDynamicProgramming/174-ClimbingStairs/Solution.cs) |
| 175 | [Min Cost Climbing Stairs](https://leetcode.com/problems/min-cost-climbing-stairs/) | Easy | 746 | [175-MinCostClimbingStairs](src/13-1DDynamicProgramming/175-MinCostClimbingStairs/Solution.cs) |
| 176 | [N-th Tribonacci Number](https://leetcode.com/problems/n-th-tribonacci-number/) | Easy | 1137 | [176-NThTribonacciNumber](src/13-1DDynamicProgramming/176-NThTribonacciNumber/Solution.cs) |
| 177 | [House Robber](https://leetcode.com/problems/house-robber/) | Medium | 198 | [177-HouseRobber](src/13-1DDynamicProgramming/177-HouseRobber/Solution.cs) |
| 178 | [House Robber II](https://leetcode.com/problems/house-robber-ii/) | Medium | 213 | [178-HouseRobberII](src/13-1DDynamicProgramming/178-HouseRobberII/Solution.cs) |
| 179 | [Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring/) | Medium | 5 | [179-LongestPalindromicSubstring](src/13-1DDynamicProgramming/179-LongestPalindromicSubstring/Solution.cs) |
| 180 | [Palindromic Substrings](https://leetcode.com/problems/palindromic-substrings/) | Medium | 647 | [180-PalindromicSubstrings](src/13-1DDynamicProgramming/180-PalindromicSubstrings/Solution.cs) |
| 181 | [Decode Ways](https://leetcode.com/problems/decode-ways/) | Medium | 91 | [181-DecodeWays](src/13-1DDynamicProgramming/181-DecodeWays/Solution.cs) |
| 182 | [Coin Change](https://leetcode.com/problems/coin-change/) | Medium | 322 | [182-CoinChange](src/13-1DDynamicProgramming/182-CoinChange/Solution.cs) |
| 183 | [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/) | Medium | 152 | [183-MaximumProductSubarray](src/13-1DDynamicProgramming/183-MaximumProductSubarray/Solution.cs) |
| 184 | [Word Break](https://leetcode.com/problems/word-break/) | Medium | 139 | [184-WordBreak](src/13-1DDynamicProgramming/184-WordBreak/Solution.cs) |
| 185 | [Longest Increasing Subsequence](https://leetcode.com/problems/longest-increasing-subsequence/) | Medium | 300 | [185-LongestIncreasingSubsequence](src/13-1DDynamicProgramming/185-LongestIncreasingSubsequence/Solution.cs) |
| 186 | [Partition Equal Subset Sum](https://leetcode.com/problems/partition-equal-subset-sum/) | Medium | 416 | [186-PartitionEqualSubsetSum](src/13-1DDynamicProgramming/186-PartitionEqualSubsetSum/Solution.cs) |
| 187 | [Combination Sum IV](https://leetcode.com/problems/combination-sum-iv/) | Medium | 377 | [187-CombinationSumIV](src/13-1DDynamicProgramming/187-CombinationSumIV/Solution.cs) |
| 188 | [Perfect Squares](https://leetcode.com/problems/perfect-squares/) | Medium | 279 | [188-PerfectSquares](src/13-1DDynamicProgramming/188-PerfectSquares/Solution.cs) |
| 189 | [Integer Break](https://leetcode.com/problems/integer-break/) | Medium | 343 | [189-IntegerBreak](src/13-1DDynamicProgramming/189-IntegerBreak/Solution.cs) |
| 190 | [Stone Game III](https://leetcode.com/problems/stone-game-iii/) | Hard | 1406 | [190-StoneGameIII](src/13-1DDynamicProgramming/190-StoneGameIII/Solution.cs) |

## 2-D Dynamic Programming

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 191 | [Unique Paths](https://leetcode.com/problems/unique-paths/) | Medium | 62 | [191-UniquePaths](src/14-2DDynamicProgramming/191-UniquePaths/Solution.cs) |
| 192 | [Unique Paths II](https://leetcode.com/problems/unique-paths-ii/) | Medium | 63 | [192-UniquePathsII](src/14-2DDynamicProgramming/192-UniquePathsII/Solution.cs) |
| 193 | [Minimum Path Sum](https://leetcode.com/problems/minimum-path-sum/) | Medium | 64 | [193-MinimumPathSum](src/14-2DDynamicProgramming/193-MinimumPathSum/Solution.cs) |
| 194 | [Longest Common Subsequence](https://leetcode.com/problems/longest-common-subsequence/) | Medium | 1143 | [194-LongestCommonSubsequence](src/14-2DDynamicProgramming/194-LongestCommonSubsequence/Solution.cs) |
| 195 | [Last Stone Weight II](https://leetcode.com/problems/last-stone-weight-ii/) | Medium | 1049 | [195-LastStoneWeightII](src/14-2DDynamicProgramming/195-LastStoneWeightII/Solution.cs) |
| 196 | [Best Time to Buy And Sell Stock With Cooldown](https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/) | Medium | 309 | [196-BestTimeToBuyAndSellStockWithCooldown](src/14-2DDynamicProgramming/196-BestTimeToBuyAndSellStockWithCooldown/Solution.cs) |
| 197 | [Coin Change II](https://leetcode.com/problems/coin-change-ii/) | Medium | 518 | [197-CoinChangeII](src/14-2DDynamicProgramming/197-CoinChangeII/Solution.cs) |
| 198 | [Target Sum](https://leetcode.com/problems/target-sum/) | Medium | 494 | [198-TargetSum](src/14-2DDynamicProgramming/198-TargetSum/Solution.cs) |
| 199 | [Interleaving String](https://leetcode.com/problems/interleaving-string/) | Medium | 97 | [199-InterleavingString](src/14-2DDynamicProgramming/199-InterleavingString/Solution.cs) |
| 200 | [Stone Game](https://leetcode.com/problems/stone-game/) | Medium | 877 | [200-StoneGame](src/14-2DDynamicProgramming/200-StoneGame/Solution.cs) |
| 201 | [Stone Game II](https://leetcode.com/problems/stone-game-ii/) | Medium | 1140 | [201-StoneGameII](src/14-2DDynamicProgramming/201-StoneGameII/Solution.cs) |
| 202 | [Longest Increasing Path In a Matrix](https://leetcode.com/problems/longest-increasing-path-in-a-matrix/) | Hard | 329 | [202-LongestIncreasingPathInAMatrix](src/14-2DDynamicProgramming/202-LongestIncreasingPathInAMatrix/Solution.cs) |
| 203 | [Distinct Subsequences](https://leetcode.com/problems/distinct-subsequences/) | Hard | 115 | [203-DistinctSubsequences](src/14-2DDynamicProgramming/203-DistinctSubsequences/Solution.cs) |
| 204 | [Edit Distance](https://leetcode.com/problems/edit-distance/) | Medium | 72 | [204-EditDistance](src/14-2DDynamicProgramming/204-EditDistance/Solution.cs) |
| 205 | [Burst Balloons](https://leetcode.com/problems/burst-balloons/) | Hard | 312 | [205-BurstBalloons](src/14-2DDynamicProgramming/205-BurstBalloons/Solution.cs) |
| 206 | [Regular Expression Matching](https://leetcode.com/problems/regular-expression-matching/) | Hard | 10 | [206-RegularExpressionMatching](src/14-2DDynamicProgramming/206-RegularExpressionMatching/Solution.cs) |

## Greedy

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 207 | [Lemonade Change](https://leetcode.com/problems/lemonade-change/) | Easy | 860 | [207-LemonadeChange](src/15-Greedy/207-LemonadeChange/Solution.cs) |
| 208 | [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/) | Medium | 53 | [208-MaximumSubarray](src/15-Greedy/208-MaximumSubarray/Solution.cs) |
| 209 | [Maximum Sum Circular Subarray](https://leetcode.com/problems/maximum-sum-circular-subarray/) | Medium | 918 | [209-MaximumSumCircularSubarray](src/15-Greedy/209-MaximumSumCircularSubarray/Solution.cs) |
| 210 | [Longest Turbulent Subarray](https://leetcode.com/problems/longest-turbulent-subarray/) | Medium | 978 | [210-LongestTurbulentSubarray](src/15-Greedy/210-LongestTurbulentSubarray/Solution.cs) |
| 211 | [Jump Game](https://leetcode.com/problems/jump-game/) | Medium | 55 | [211-JumpGame](src/15-Greedy/211-JumpGame/Solution.cs) |
| 212 | [Jump Game II](https://leetcode.com/problems/jump-game-ii/) | Medium | 45 | [212-JumpGameII](src/15-Greedy/212-JumpGameII/Solution.cs) |
| 213 | [Jump Game VII](https://leetcode.com/problems/jump-game-vii/) | Medium | 1871 | [213-JumpGameVII](src/15-Greedy/213-JumpGameVII/Solution.cs) |
| 214 | [Gas Station](https://leetcode.com/problems/gas-station/) | Medium | 134 | [214-GasStation](src/15-Greedy/214-GasStation/Solution.cs) |
| 215 | [Hand of Straights](https://leetcode.com/problems/hand-of-straights/) | Medium | 846 | [215-HandOfStraights](src/15-Greedy/215-HandOfStraights/Solution.cs) |
| 216 | [Dota2 Senate](https://leetcode.com/problems/dota2-senate/) | Medium | 649 | [216-Dota2Senate](src/15-Greedy/216-Dota2Senate/Solution.cs) |
| 217 | [Merge Triplets to Form Target Triplet](https://leetcode.com/problems/merge-triplets-to-form-target-triplet/) | Medium | 1899 | [217-MergeTripletsToFormTargetTriplet](src/15-Greedy/217-MergeTripletsToFormTargetTriplet/Solution.cs) |
| 218 | [Partition Labels](https://leetcode.com/problems/partition-labels/) | Medium | 763 | [218-PartitionLabels](src/15-Greedy/218-PartitionLabels/Solution.cs) |
| 219 | [Valid Parenthesis String](https://leetcode.com/problems/valid-parenthesis-string/) | Medium | 678 | [219-ValidParenthesisString](src/15-Greedy/219-ValidParenthesisString/Solution.cs) |
| 220 | [Candy](https://leetcode.com/problems/candy/) | Hard | 135 | [220-Candy](src/15-Greedy/220-Candy/Solution.cs) |

## Intervals

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 221 | [Insert Interval](https://leetcode.com/problems/insert-interval/) | Medium | 57 | [221-InsertInterval](src/16-Intervals/221-InsertInterval/Solution.cs) |
| 222 | [Merge Intervals](https://leetcode.com/problems/merge-intervals/) | Medium | 56 | [222-MergeIntervals](src/16-Intervals/222-MergeIntervals/Solution.cs) |
| 223 | [Non Overlapping Intervals](https://leetcode.com/problems/non-overlapping-intervals/) | Medium | 435 | [223-NonOverlappingIntervals](src/16-Intervals/223-NonOverlappingIntervals/Solution.cs) |
| 224 | [Meeting Rooms](https://neetcode.io/problems/meeting-schedule/question) (NeetCode) | Easy | 252 | [224-MeetingRooms](src/16-Intervals/224-MeetingRooms/Solution.cs) |
| 225 | [Meeting Rooms II](https://neetcode.io/problems/meeting-schedule-ii/question) (NeetCode) | Medium | 253 | [225-MeetingRoomsII](src/16-Intervals/225-MeetingRoomsII/Solution.cs) |
| 226 | [Meeting Rooms III](https://leetcode.com/problems/meeting-rooms-iii/) | Hard | 2402 | [226-MeetingRoomsIII](src/16-Intervals/226-MeetingRoomsIII/Solution.cs) |
| 227 | [Minimum Interval to Include Each Query](https://leetcode.com/problems/minimum-interval-to-include-each-query/) | Hard | 1851 | [227-MinimumIntervalToIncludeEachQuery](src/16-Intervals/227-MinimumIntervalToIncludeEachQuery/Solution.cs) |

## Bit Manipulation

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 228 | [Single Number](https://leetcode.com/problems/single-number/) | Easy | 136 | [228-SingleNumber](src/17-BitManipulation/228-SingleNumber/Solution.cs) |
| 229 | [Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/) | Easy | 191 | [229-NumberOf1Bits](src/17-BitManipulation/229-NumberOf1Bits/Solution.cs) |
| 230 | [Counting Bits](https://leetcode.com/problems/counting-bits/) | Easy | 338 | [230-CountingBits](src/17-BitManipulation/230-CountingBits/Solution.cs) |
| 231 | [Add Binary](https://leetcode.com/problems/add-binary/) | Easy | 67 | [231-AddBinary](src/17-BitManipulation/231-AddBinary/Solution.cs) |
| 232 | [Reverse Bits](https://leetcode.com/problems/reverse-bits/) | Easy | 190 | [232-ReverseBits](src/17-BitManipulation/232-ReverseBits/Solution.cs) |
| 233 | [Missing Number](https://leetcode.com/problems/missing-number/) | Easy | 268 | [233-MissingNumber](src/17-BitManipulation/233-MissingNumber/Solution.cs) |
| 234 | [Sum of Two Integers](https://leetcode.com/problems/sum-of-two-integers/) | Medium | 371 | [234-SumOfTwoIntegers](src/17-BitManipulation/234-SumOfTwoIntegers/Solution.cs) |
| 235 | [Reverse Integer](https://leetcode.com/problems/reverse-integer/) | Medium | 7 | [235-ReverseInteger](src/17-BitManipulation/235-ReverseInteger/Solution.cs) |
| 236 | [Bitwise AND of Numbers Range](https://leetcode.com/problems/bitwise-and-of-numbers-range/) | Medium | 201 | [236-BitwiseANDOfNumbersRange](src/17-BitManipulation/236-BitwiseANDOfNumbersRange/Solution.cs) |
| 237 | [Minimum Array End](https://leetcode.com/problems/minimum-array-end/) | Medium | 3133 | [237-MinimumArrayEnd](src/17-BitManipulation/237-MinimumArrayEnd/Solution.cs) |

## Math & Geometry

| # | Problem | Difficulty | LC # | Project |
|---|---|---|---|---|
| 238 | [Excel Sheet Column Title](https://leetcode.com/problems/excel-sheet-column-title/) | Easy | 168 | [238-ExcelSheetColumnTitle](src/18-MathGeometry/238-ExcelSheetColumnTitle/Solution.cs) |
| 239 | [Greatest Common Divisor of Strings](https://leetcode.com/problems/greatest-common-divisor-of-strings/) | Easy | 1071 | [239-GreatestCommonDivisorOfStrings](src/18-MathGeometry/239-GreatestCommonDivisorOfStrings/Solution.cs) |
| 240 | [Insert Greatest Common Divisors in Linked List](https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/) | Medium | 2807 | [240-InsertGreatestCommonDivisorsInLinkedList](src/18-MathGeometry/240-InsertGreatestCommonDivisorsInLinkedList/Solution.cs) |
| 241 | [Transpose Matrix](https://leetcode.com/problems/transpose-matrix/) | Easy | 867 | [241-TransposeMatrix](src/18-MathGeometry/241-TransposeMatrix/Solution.cs) |
| 242 | [Rotate Image](https://leetcode.com/problems/rotate-image/) | Medium | 48 | [242-RotateImage](src/18-MathGeometry/242-RotateImage/Solution.cs) |
| 243 | [Spiral Matrix](https://leetcode.com/problems/spiral-matrix/) | Medium | 54 | [243-SpiralMatrix](src/18-MathGeometry/243-SpiralMatrix/Solution.cs) |
| 244 | [Set Matrix Zeroes](https://leetcode.com/problems/set-matrix-zeroes/) | Medium | 73 | [244-SetMatrixZeroes](src/18-MathGeometry/244-SetMatrixZeroes/Solution.cs) |
| 245 | [Happy Number](https://leetcode.com/problems/happy-number/) | Easy | 202 | [245-HappyNumber](src/18-MathGeometry/245-HappyNumber/Solution.cs) |
| 246 | [Plus One](https://leetcode.com/problems/plus-one/) | Easy | 66 | [246-PlusOne](src/18-MathGeometry/246-PlusOne/Solution.cs) |
| 247 | [Roman to Integer](https://leetcode.com/problems/roman-to-integer/) | Easy | 13 | [247-RomanToInteger](src/18-MathGeometry/247-RomanToInteger/Solution.cs) |
| 248 | [Pow(x, n)](https://leetcode.com/problems/powx-n/) | Medium | 50 | [248-PowXN](src/18-MathGeometry/248-PowXN/Solution.cs) |
| 249 | [Multiply Strings](https://leetcode.com/problems/multiply-strings/) | Medium | 43 | [249-MultiplyStrings](src/18-MathGeometry/249-MultiplyStrings/Solution.cs) |
| 250 | [Detect Squares](https://leetcode.com/problems/detect-squares/) | Medium | 2013 | [250-DetectSquares](src/18-MathGeometry/250-DetectSquares/Solution.cs) |

