# LeetCode Top Interview 150 — C# Practice

這個 Repository 用來記錄我的 **LeetCode Top Interview 150** 練習過程。

主要使用 **C#** 解題，目標不是單純累積刷題數量，而是建立常見面試題型的 **Problem-Solving Patterns**，並透過重複練習、分類整理與定期複習，提高在技術面試中獨立分析與解題的能力。

---

## 🎯 Goals

* 熟悉常見資料結構與演算法
* 建立面試題型 Pattern
* 提升 C# 解題熟練度
* 練習時間與空間複雜度分析
* 減少對題解與提示的依賴
* 能在限定時間內完成 Easy / Medium 題目
* 為 Software Engineer 技術面試做準備

---

# 🧭 Study Roadmap

## Phase 1 — Build Interview Patterns

> 第一階段重點：先建立常見面試 Pattern，而不是追求完成 150 題。

優先熟悉高頻、可重複套用的解題模式。

### Topics

1. Hash Map / Hash Set
2. Two Pointers
3. Sliding Window
4. Stack
5. Binary Search
6. Array / String Fundamentals

### Core Patterns

#### Hash Map

常見問題：

* 快速查找
* Frequency Count
* Complement Lookup
* Duplicate Detection
* Grouping

Example:

```text
value → count
value → index
key → group
```

代表題型：

* Two Sum
* Valid Anagram
* Group Anagrams
* Longest Consecutive Sequence

---

#### Two Pointers

常見條件：

* Sorted Array
* 左右夾逼
* 原地修改
* Pair / Triplet Search

Example:

```text
left  →      ←  right
```

代表題型：

* Valid Palindrome
* Two Sum II
* Container With Most Water
* 3Sum

---

#### Sliding Window

常見條件：

* Contiguous Subarray
* Contiguous Substring
* Longest / Shortest Range
* Dynamic Range

核心概念：

```text
Expand Right
↓
Condition Invalid
↓
Shrink Left
```

代表題型：

* Longest Substring Without Repeating Characters
* Minimum Size Subarray Sum
* Minimum Window Substring

---

#### Stack

常見條件：

* Matching
* Nested Structure
* Expression Evaluation
* Monotonic Relationship

代表題型：

* Valid Parentheses
* Min Stack
* Evaluate Reverse Polish Notation
* Basic Calculator

---

#### Binary Search

不只是搜尋某個值。

需要熟悉：

```text
Find Exact Value
Find First Position
Find Last Position
Find Minimum Valid Answer
Search Rotated Array
Binary Search on Answer
```

代表題型：

* Search Insert Position
* Search in Rotated Sorted Array
* Find First and Last Position
* Find Minimum in Rotated Sorted Array

---

### Phase 1 Goal

完成第一階段後，應該能做到：

* 看到題目時先辨識 Pattern
* 能說明為什麼選擇 Dictionary / HashSet
* 能判斷 Two Pointers 與 Sliding Window 的差異
* 能獨立寫出基本 Binary Search
* 能分析時間與空間複雜度
* Easy 題大部分能獨立完成
* Medium 題開始能辨識解題方向

---

# Phase 2 — Core Data Structures

> 第二階段重點：建立 Linked List、Tree、Graph 等核心資料結構的操作能力。

### Topics

1. Linked List
2. Binary Tree
3. Binary Search Tree
4. Tree BFS / DFS
5. Graph
6. Matrix
7. Intervals
8. Heap / Priority Queue

---

## Linked List

需要熟悉：

* Dummy Node
* Fast / Slow Pointer
* Reverse Linked List
* Merge Lists
* Remove Node
* Cycle Detection

代表題型：

* Linked List Cycle
* Merge Two Sorted Lists
* Remove Nth Node From End
* Reverse Linked List II
* LRU Cache

---

## Binary Tree

核心 Traversal：

```text
Preorder
Inorder
Postorder
Level Order
```

需要熟悉：

```text
DFS Recursive
DFS Iterative
BFS Queue
```

代表題型：

* Maximum Depth of Binary Tree
* Invert Binary Tree
* Path Sum
* Lowest Common Ancestor
* Binary Tree Maximum Path Sum

---

## Binary Search Tree

核心特性：

```text
Left < Root < Right
```

需要熟悉：

* Inorder Traversal
* Validate BST
* Kth Smallest
* Range / Boundary Thinking

---

## Graph

核心表示方式：

```text
Adjacency List
Matrix
Implicit Graph
```

核心搜尋：

```text
DFS
BFS
Visited Set
Topological Sort
```

代表題型：

* Number of Islands
* Clone Graph
* Course Schedule
* Course Schedule II
* Word Ladder

---

## Heap / Priority Queue

適合：

* Top K
* Kth Largest
* Dynamic Minimum / Maximum
* Streaming Data

C# 常用：

```csharp
PriorityQueue<TElement, TPriority>
```

代表題型：

* Kth Largest Element in an Array
* Find K Pairs with Smallest Sums
* Find Median from Data Stream

---

### Phase 2 Goal

完成第二階段後，應該能做到：

* 熟悉 Linked List pointer 操作
* 能獨立實作 Tree DFS / BFS
* 能判斷 Graph 問題使用 BFS 或 DFS
* 理解 Topological Sort
* 能使用 Heap 解 Top K 類問題
* 能處理常見 Medium 面試題

---

# Phase 3 — Advanced Problem Solving

> 第三階段重點：處理需要多步推理、狀態設計與組合搜尋的問題。

### Topics

1. Backtracking
2. Trie
3. Divide & Conquer
4. Kadane's Algorithm
5. Bit Manipulation
6. Math
7. Dynamic Programming

---

## Backtracking

核心模板：

```text
Choose
↓
Explore
↓
Undo
```

常見問題：

* Combination
* Permutation
* Subset
* Search
* Constraint Satisfaction

代表題型：

* Letter Combinations
* Combinations
* Permutations
* Combination Sum
* N-Queens
* Generate Parentheses
* Word Search

---

## Dynamic Programming

DP 不以背公式為主要目標。

優先思考：

```text
1. State 是什麼？
2. Transition 是什麼？
3. Base Case 是什麼？
4. 計算順序是什麼？
5. 能否壓縮空間？
```

### 1D DP

代表題型：

* Climbing Stairs
* House Robber
* Word Break
* Coin Change
* Longest Increasing Subsequence

### Multidimensional DP

代表題型：

* Minimum Path Sum
* Longest Palindromic Substring
* Edit Distance
* Best Time to Buy and Sell Stock III
* Maximal Square

---

### Phase 3 Goal

完成第三階段後，應該能做到：

* 能定義 DP State
* 能推導 State Transition
* 能寫出基本 Backtracking Template
* 能辨識 Combination / Permutation 問題
* 能處理較複雜 Medium 題
* 開始挑戰部分 Hard 題

---

# Phase 4 — Interview Simulation

> 第四階段不是學新題型，而是測試自己能否在壓力下獨立完成問題。

## Practice Rules

每次模擬：

```text
Easy   → 15–20 min
Medium → 25–40 min
Hard   → 45–60 min
```

解題流程：

```text
1. Clarify Requirements
2. Identify Constraints
3. Explain Brute Force
4. Identify Pattern
5. Design Optimized Solution
6. Analyze Complexity
7. Write Code
8. Test Edge Cases
```

---

## Interview Checklist

寫程式前：

* [ ] 是否理解 Input / Output？
* [ ] 是否確認 Constraints？
* [ ] 是否想到 Brute Force？
* [ ] 是否能辨識 Pattern？
* [ ] 是否有更好的 Data Structure？

寫程式後：

* [ ] Empty Input
* [ ] Single Element
* [ ] Duplicate Values
* [ ] Negative Values
* [ ] Boundary Conditions
* [ ] Integer Overflow
* [ ] Time Complexity
* [ ] Space Complexity

---

# 📊 Progress Status

每題使用以下狀態：

```text
Not Started
↓
Attempted
↓
Solved w/ Help
↓
Solved
↓
Mastered
```

## Status Definition

| Status         | Definition  |
| -------------- | ----------- |
| Not Started    | 尚未開始        |
| Attempted      | 嘗試過但未完成     |
| Solved w/ Help | 查看提示或題解後完成  |
| Solved         | 能獨立完成       |
| Mastered       | 隔一段時間仍能獨立完成 |

---

# 🔁 Review Strategy

解出一次不代表真正掌握。

使用 Confidence Level：

| Confidence | Meaning | Suggested Review |
| ---------- | ------- | ---------------- |
| 1          | 幾乎不會    | 1 day            |
| 2          | 需要大量提示  | 3 days           |
| 3          | 大致理解    | 7 days           |
| 4          | 能獨立完成   | 14 days          |
| 5          | 熟練掌握    | 30 days          |

複習時：

> 不先閱讀舊程式碼。

先重新分析：

```text
What pattern is this?
Why does it work?
What is the complexity?
Can I implement it from scratch?
```

---

# 🧠 Problem-Solving Notes

每題至少記錄：

```text
Pattern:
Key Insight:
Why It Works:
Time Complexity:
Space Complexity:
Mistakes:
Review Notes:
```

Example:

```text
Pattern:
Sliding Window

Key Insight:
The window always contains unique characters.

Why It Works:
When a duplicate appears, move the left pointer
until the window becomes valid again.

Time Complexity:
O(n)

Space Complexity:
O(k)

Mistakes:
Initially moved left only once instead of shrinking
until the duplicate condition was removed.
```

---

# 📁 Repository Structure

```text
LeetCode150/
├─ src/
│  ├─ ArrayString/
│  │  ├─ P001_MergeSortedArray/
│  │  │  └─ Solution.cs
│  │  └─ ...
│  │
│  ├─ TwoPointers/
│  ├─ SlidingWindow/
│  ├─ Hashmap/
│  ├─ Stack/
│  ├─ LinkedList/
│  ├─ BinaryTree/
│  ├─ Graph/
│  ├─ Heap/
│  └─ DynamicProgramming/
│
├─ tests/
│  └─ ...
│
├─ notes/
│  ├─ array-string.md
│  ├─ two-pointers.md
│  ├─ sliding-window.md
│  ├─ binary-search.md
│  ├─ linked-list.md
│  ├─ tree.md
│  ├─ graph.md
│  └─ dynamic-programming.md
│
├─ README.md
└─ LeetCode150.sln
```

---

# 💻 Language

Primary language:

```text
C#
```

Common collections:

```csharp
Dictionary<TKey, TValue>
HashSet<T>
List<T>
Queue<T>
Stack<T>
PriorityQueue<TElement, TPriority>
```

---

# 🛠 Development Tools

Recommended workflow:

```text
Notion
└─ Progress Tracking

Git
└─ Version Control

VS Code
└─ Daily Problem Solving

Visual Studio 2022
└─ Debugging / Testing
```

---

# 📝 Commit Convention

Example:

```text
solve: two sum
solve: valid palindrome
solve: longest substring without repeating characters
review: binary search
refactor: simplify merge intervals solution
test: add edge cases for rotate array
docs: add sliding window pattern notes
```

Optional format with problem number:

```text
solve: [001] merge sorted array
solve: [029] 3sum
review: [031] longest substring without repeating characters
```

---

# ✅ Definition of Mastered

一題只有符合以下條件，才標記為 `Mastered`：

* [ ] 沒有查看舊程式碼
* [ ] 沒有查看 Solution
* [ ] 能辨識 Pattern
* [ ] 能解釋核心思路
* [ ] 能獨立完成程式碼
* [ ] 能分析 Time Complexity
* [ ] 能分析 Space Complexity
* [ ] 能處理 Edge Cases
* [ ] 隔一段時間仍能重新完成

---

# 🚀 Final Objective

最終目標不是：

> I solved 150 problems.

而是：

> I can identify common interview patterns, explain my reasoning clearly, implement solutions in C#, analyze complexity, and solve unfamiliar problems independently.

---

## Current Focus

```text
Phase 1 — Build Interview Patterns
```

Priority:

```text
Hash Map
→ Two Pointers
→ Sliding Window
→ Stack
→ Binary Search
→ Array / String
```

Focus on understanding patterns first.

Speed comes later.

## 📌 Local Problem Index Mapping

This table maps the local folder index used in this repository to the actual LeetCode problem number.

Example:

```text
P045_HappyNumber <-> 202. Happy Number
```

| Local Index | LeetCode Problem |
|---|---|
| P001_MergeSortedArray | 88. Merge Sorted Array |
| P002_RemoveElement | 27. Remove Element |
| P003_RemoveDuplicatesFromSortedArray | 26. Remove Duplicates from Sorted Array |
| P004_RemoveDuplicatesFromSortedArrayII | 80. Remove Duplicates from Sorted Array II |
| P005_MajorityElement | 169. Majority Element |
| P006_RotateArray | 189. Rotate Array |
| P007_BestTimeToBuyAndSellStock | 121. Best Time to Buy and Sell Stock |
| P008_BestTimeToBuyAndSellStockII | 122. Best Time to Buy and Sell Stock II |
| P009_JumpGame | 55. Jump Game |
| P010_JumpGameII | 45. Jump Game II |
| P011_HIndex | 274. H-Index |
| P012_InsertDeleteGetRandomO1 | 380. Insert Delete GetRandom O(1) |
| P013_ProductOfArrayExceptSelf | 238. Product of Array Except Self |
| P014_GasStation | 134. Gas Station |
| P015_Candy | 135. Candy |
| P016_TrappingRainWater | 42. Trapping Rain Water |
| P017_RomanToInteger | 13. Roman to Integer |
| P018_IntegerToRoman | 12. Integer to Roman |
| P019_LengthOfLastWord | 58. Length of Last Word |
| P020_LongestCommonPrefix | 14. Longest Common Prefix |
| P021_ReverseWordsInAString | 151. Reverse Words in a String |
| P022_ZigzagConversion | 6. Zigzag Conversion |
| P023_FindTheIndexOfTheFirstOccurrenceInAString | 28. Find the Index of the First Occurrence in a String |
| P024_TextJustification | 68. Text Justification |
| P025_ValidPalindrome | 125. Valid Palindrome |
| P026_IsSubsequence | 392. Is Subsequence |
| P027_TwoSumIIInputArrayIsSorted | 167. Two Sum II - Input Array Is Sorted |
| P028_ContainerWithMostWater | 11. Container With Most Water |
| P029_3Sum | 15. 3Sum |
| P030_MinimumSizeSubarraySum | 209. Minimum Size Subarray Sum |
| P031_LongestSubstringWithoutRepeatingCharacters | 3. Longest Substring Without Repeating Characters |
| P032_SubstringWithConcatenationOfAllWords | 30. Substring with Concatenation of All Words |
| P033_MinimumWindowSubstring | 76. Minimum Window Substring |
| P034_ValidSudoku | 36. Valid Sudoku |
| P035_SpiralMatrix | 54. Spiral Matrix |
| P036_RotateImage | 48. Rotate Image |
| P037_SetMatrixZeroes | 73. Set Matrix Zeroes |
| P038_GameOfLife | 289. Game of Life |
| P039_RansomNote | 383. Ransom Note |
| P040_IsomorphicStrings | 205. Isomorphic Strings |
| P041_WordPattern | 290. Word Pattern |
| P042_ValidAnagram | 242. Valid Anagram |
| P043_GroupAnagrams | 49. Group Anagrams |
| P044_TwoSum | 1. Two Sum |
| P045_HappyNumber | 202. Happy Number |
| P046_ContainsDuplicateII | 219. Contains Duplicate II |
| P047_LongestConsecutiveSequence | 128. Longest Consecutive Sequence |
| P048_SummaryRanges | 228. Summary Ranges |
| P049_MergeIntervals | 56. Merge Intervals |
| P050_InsertInterval | 57. Insert Interval |
| P051_MinimumNumberOfArrowsToBurstBalloons | 452. Minimum Number of Arrows to Burst Balloons |
| P052_ValidParentheses | 20. Valid Parentheses |
| P053_SimplifyPath | 71. Simplify Path |
| P054_MinStack | 155. Min Stack |
| P055_EvaluateReversePolishNotation | 150. Evaluate Reverse Polish Notation |
| P056_BasicCalculator | 224. Basic Calculator |
| P057_LinkedListCycle | 141. Linked List Cycle |
| P058_AddTwoNumbers | 2. Add Two Numbers |
| P059_MergeTwoSortedLists | 21. Merge Two Sorted Lists |
| P060_CopyListWithRandomPointer | 138. Copy List with Random Pointer |
| P061_ReverseLinkedListII | 92. Reverse Linked List II |
| P062_ReverseNodesInKGroup | 25. Reverse Nodes in k-Group |
| P063_RemoveNthNodeFromEndOfList | 19. Remove Nth Node From End of List |
| P064_RemoveDuplicatesFromSortedListII | 82. Remove Duplicates from Sorted List II |
| P065_RotateList | 61. Rotate List |
| P066_PartitionList | 86. Partition List |
| P067_LRUCache | 146. LRU Cache |
| P068_MaximumDepthOfBinaryTree | 104. Maximum Depth of Binary Tree |
| P069_SameTree | 100. Same Tree |
| P070_InvertBinaryTree | 226. Invert Binary Tree |
| P071_SymmetricTree | 101. Symmetric Tree |
| P072_ConstructBinaryTreeFromPreorderAndInorderTraversal | 105. Construct Binary Tree from Preorder and Inorder Traversal |
| P073_ConstructBinaryTreeFromInorderAndPostorderTraversal | 106. Construct Binary Tree from Inorder and Postorder Traversal |
| P074_PopulatingNextRightPointersInEachNodeII | 117. Populating Next Right Pointers in Each Node II |
| P075_FlattenBinaryTreeToLinkedList | 114. Flatten Binary Tree to Linked List |
| P076_PathSum | 112. Path Sum |
| P077_SumRootToLeafNumbers | 129. Sum Root to Leaf Numbers |
| P078_BinaryTreeMaximumPathSum | 124. Binary Tree Maximum Path Sum |
| P079_BinarySearchTreeIterator | 173. Binary Search Tree Iterator |
| P080_CountCompleteTreeNodes | 222. Count Complete Tree Nodes |
| P081_LowestCommonAncestorOfABinaryTree | 236. Lowest Common Ancestor of a Binary Tree |
| P082_BinaryTreeRightSideView | 199. Binary Tree Right Side View |
| P083_AverageOfLevelsInBinaryTree | 637. Average of Levels in Binary Tree |
| P084_BinaryTreeLevelOrderTraversal | 102. Binary Tree Level Order Traversal |
| P085_BinaryTreeZigzagLevelOrderTraversal | 103. Binary Tree Zigzag Level Order Traversal |
| P086_MinimumAbsoluteDifferenceInBST | 530. Minimum Absolute Difference in BST |
| P087_KthSmallestElementInABST | 230. Kth Smallest Element in a BST |
| P088_ValidateBinarySearchTree | 98. Validate Binary Search Tree |
| P089_NumberOfIslands | 200. Number of Islands |
| P090_SurroundedRegions | 130. Surrounded Regions |
| P091_CloneGraph | 133. Clone Graph |
| P092_EvaluateDivision | 399. Evaluate Division |
| P093_CourseSchedule | 207. Course Schedule |
| P094_CourseScheduleII | 210. Course Schedule II |
| P095_SnakesAndLadders | 909. Snakes and Ladders |
| P096_MinimumGeneticMutation | 433. Minimum Genetic Mutation |
| P097_WordLadder | 127. Word Ladder |
| P098_ImplementTriePrefixTree | 208. Implement Trie (Prefix Tree) |
| P099_DesignAddAndSearchWordsDataStructure | 211. Design Add and Search Words Data Structure |
| P100_WordSearchII | 212. Word Search II |
| P101_LetterCombinationsOfAPhoneNumber | 17. Letter Combinations of a Phone Number |
| P102_Combinations | 77. Combinations |
| P103_Permutations | 46. Permutations |
| P104_CombinationSum | 39. Combination Sum |
| P105_NQueensII | 52. N-Queens II |
| P106_GenerateParentheses | 22. Generate Parentheses |
| P107_WordSearch | 79. Word Search |
| P108_ConvertSortedArrayToBinarySearchTree | 108. Convert Sorted Array to Binary Search Tree |
| P109_SortList | 148. Sort List |
| P110_ConstructQuadTree | 427. Construct Quad Tree |
| P111_MergeKSortedLists | 23. Merge k Sorted Lists |
| P112_MaximumSubarray | 53. Maximum Subarray |
| P113_MaximumSumCircularSubarray | 918. Maximum Sum Circular Subarray |
| P114_SearchInsertPosition | 35. Search Insert Position |
| P115_SearchA2DMatrix | 74. Search a 2D Matrix |
| P116_FindPeakElement | 162. Find Peak Element |
| P117_SearchInRotatedSortedArray | 33. Search in Rotated Sorted Array |
| P118_FindFirstAndLastPositionOfElementInSortedArray | 34. Find First and Last Position of Element in Sorted Array |
| P119_FindMinimumInRotatedSortedArray | 153. Find Minimum in Rotated Sorted Array |
| P120_MedianOfTwoSortedArrays | 4. Median of Two Sorted Arrays |
| P121_KthLargestElementInAnArray | 215. Kth Largest Element in an Array |
| P122_IPO | 502. IPO |
| P123_FindKPairsWithSmallestSums | 373. Find K Pairs with Smallest Sums |
| P124_FindMedianFromDataStream | 295. Find Median from Data Stream |
| P125_AddBinary | 67. Add Binary |
| P126_ReverseBits | 190. Reverse Bits |
| P127_NumberOf1Bits | 191. Number of 1 Bits |
| P128_SingleNumber | 136. Single Number |
| P129_SingleNumberII | 137. Single Number II |
| P130_BitwiseANDOfNumbersRange | 201. Bitwise AND of Numbers Range |
| P131_PalindromeNumber | 9. Palindrome Number |
| P132_PlusOne | 66. Plus One |
| P133_FactorialTrailingZeroes | 172. Factorial Trailing Zeroes |
| P134_SqrtX | 69. Sqrt(x) |
| P135_PowXN | 50. Pow(x, n) |
| P136_MaxPointsOnALine | 149. Max Points on a Line |
| P137_ClimbingStairs | 70. Climbing Stairs |
| P138_HouseRobber | 198. House Robber |
| P139_WordBreak | 139. Word Break |
| P140_CoinChange | 322. Coin Change |
| P141_LongestIncreasingSubsequence | 300. Longest Increasing Subsequence |
| P142_Triangle | 120. Triangle |
| P143_MinimumPathSum | 64. Minimum Path Sum |
| P144_UniquePathsII | 63. Unique Paths II |
| P145_LongestPalindromicSubstring | 5. Longest Palindromic Substring |
| P146_InterleavingString | 97. Interleaving String |
| P147_EditDistance | 72. Edit Distance |
| P148_BestTimeToBuyAndSellStockIII | 123. Best Time to Buy and Sell Stock III |
| P149_BestTimeToBuyAndSellStockIV | 188. Best Time to Buy and Sell Stock IV |
| P150_MaximalSquare | 221. Maximal Square |