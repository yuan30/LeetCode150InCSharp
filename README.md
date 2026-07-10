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
