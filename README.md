# DATA STRUCTURES AND ALGORITHMS -GIT
# DATA STRUCTURES & ALGORITHMS
# DAY 1

- Create a new repository for **DSA**
- Create **7 empty folders** from `Day1` to `Day7`
- Start with **DSA fundamentals**
- Understand the basics before implementations

## THEORY
- What is **Data**
- What is a **Data Structure**
- What is an **Algorithm**
- Difference between **Data Structure vs Algorithm**

Example concept  
Data Structure → How data is stored  
Algorithm → Steps to process the data

- Types of **Data Structures (Classification only)**

Primitive  
int  
float  
char  
bool  

Non-Primitive  

Linear  
Array  
Linked List  
Stack  
Queue  

Non-Linear  
Tree  
Graph  

Note: Only understand the **classification today**.  
Do NOT study Tree structures, Graph algorithms, or Stack operations yet.

## ALGORITHM CHARACTERISTICS
Learn these 5 properties

- Input  
- Output  
- Definiteness  
- Finiteness  
- Effectiveness  

## PRACTICAL
Practice writing **simple algorithms as C# methods**

- Find largest number in an array  
`int FindMax(int[] arr)`

- Count even numbers in an array  
`int CountEven(int[] arr)`

- Reverse an array  
`int[] ReverseArray(int[] arr)`

## INTERVIEW PREPARATION
Be able to answer

What is a **Data Structure**  
A way of organizing and storing data so it can be used efficiently.

Difference between **Algorithm and Data Structure**

Data Structure → Organizes and stores data  
Algorithm → Step-by-step process to solve a problem

# DAY 2 — Time Complexity & Big O

## Learn These Concepts

### Why Complexity Matters
* **Example:** Imagine searching for a specific item in a list of 1,000,000 items. Which algorithm gets you the result faster, and how does the time taken scale as the list grows? 

---

### Big O Notation


[Image of Big O time complexity chart]


**Learn ONLY these:**
* `O(1)` — *Constant Time*
* `O(log n)` — *Logarithmic Time*
* `O(n)` — *Linear Time*
* `O(n log n)` — *Linearithmic Time*
* `O(n²)` — *Quadratic Time*

> **Goal:** Understand exactly what each of these time complexities means conceptually and how they affect performance.

**🚫 Do NOT study:**
* Master Theorem
* Advanced mathematical analysis

---

## C# Practice

**Task:** Write various functions and determine their Big O time complexity. 

**Example:**
```csharp
void PrintNumbers(int n)
{
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine(i);
    }
}

# DAY 3 — Arrays

## Learn

### What is an Array

**Properties**
- Fixed size
- Continuous memory
- Index based access

### Array Operations
Learn only these
- Traversal
- Insertion
- Deletion
- Searching

### C# Implementation
Create arrays
```csharp
int[] arr = {5,3,8,2,1};
```

## Practice
- Traverse array
- Insert element at position
- Delete element

## Practice Problems
- Reverse array
- Find second largest
- Count duplicates

## Interview Points
- Array advantages
- Array disadvantage

---

# DAY 4 — Linked List

## Learn

### Why linked list exists.

**Problem with array**
- Insertion expensive
- Fixed size

**Solution**
- Linked List

### Structure of Node
- Data
- Next pointer

### Types (just understand names)
- Singly Linked List
- Doubly Linked List
- Circular Linked List

### C# Implementation
Create Node class
```csharp
class Node
{
    public int data;
    public Node next
}
```

**Implement**
- [ ] Insert at beginning
- [ ] Insert at end
- [ ] Traverse list

## Practice
Write methods:
- `AddFirst()`
- `AddLast()`
- `Display()`

---

# DAY 5 — Stack

## Learn

### Stack principle:
**LIFO**
Last In First Out

**Examples**
- Undo operation
- Browser history
- Plate stack

### Stack Operations
Learn these
- Push
- Pop
- Peek
- IsEmpty

### C# Implementation
First use built-in
```csharp
Stack<int> stack = new Stack<int>();
```
Then implement your own stack using array.

## Practice Problems
- [ ] Reverse string using stack
- [ ] Balanced parentheses

Example:
```
{[()]}
```

---

# DAY 6 — Queue

## Learn

### Queue principle
**FIFO**
First In First Out

**Examples:**
- Printer queue
- Ticket line
- Task scheduling

### Queue Operations
- Enqueue
- Dequeue
- Peek
- IsEmpty

### C# Implementation
```csharp
Queue<int> queue = new Queue<int>();
```
Also implement queue using array.

## Practice
- [ ] Simulate printer queue
- [ ] Print queue elements

---

# DAY 7 — Recursion

## Learn

### Definition:
Function calling itself

**Understand:**
- Base condition
- Recursive call

### C# Practice
**Factorial**
```csharp
int Factorial(int n)
```

**Fibonacci**
- [ ] Study dynamic programming.

## Practice
- Factorial
- Fibonacci
- Sum of numbers using recursion
// Time Complexity: O(n)


# DAY 8 — Searching Algorithms

## Linear Search
**Concept:**
Check every element.

**Time complexity:**
O(n)

## Binary Search
**Requirement:**
Array must be sorted

**Time complexity:**
O(log n)

## C# Practice
Implement:
- LinearSearch()
- BinarySearch()

# DAY 9 — Basic Sorting

## Learn these 3:
- Bubble Sort
- Selection Sort
- Insertion Sort

## Bubble Sort
**Concept:**
Compare adjacent elements and swap if they are in wrong order. Repeat until sorted.

**Time Complexity:**
- Best: O(n)
- Worst: O(n²)

## Selection Sort
**Concept:**
Find the minimum element and place it at the correct position.

**Time Complexity:**
- Best: O(n²)
- Worst: O(n²)

## Insertion Sort
**Concept:**
Pick each element and insert it into its correct position in the already sorted part.

**Time Complexity:**
- Best: O(n)
- Worst: O(n²)

## C# Practice
Implement:
- BubbleSort()
- SelectionSort()
- InsertionSort()

# DAY 10 — Efficient Sorting

## Learn:
- Merge Sort
- Quick Sort

## Understand:
- Divide and Conquer

## Divide and Conquer
**Concept:**
Split the problem into smaller subproblems, solve each, then combine results.

- **Divide** → Split problem into smaller parts
- **Conquer** → Solve each small part
- **Combine** → Merge results together

## Merge Sort
**Concept:**
Split array in half recursively until single elements, then merge back in sorted order.

**Time Complexity:**
- Best: O(n log n)
- Worst: O(n log n)

## Quick Sort
**Concept:**
Pick a pivot element, place it in correct position, recursively sort left and right sides.

**Time Complexity:**
- Best: O(n log n)
- Worst: O(n²)

## C# Practice
Implement:
- MergeSort()
- Merge()
- QuickSort()
- Partition()

# DAY 11 — Trees

## Learn:
- Tree Terminology
- Binary Tree
- Tree Traversals

## Tree Terminology
- **Root** → top node, has no parent
- **Parent** → node that has children
- **Child** → node that has a parent
- **Leaf** → node with no children
- **Height** → longest path from root to leaf

## Binary Tree
**Concept:**
A tree where each node has at most 2 children — left and right (0, 1, or 2).

## Tree Traversals

**Inorder** → Left → Root → Right

**Preorder** → Root → Left → Right

**Postorder** → Left → Right → Root

## C# Practice
Implement:
- Node class
- BinaryTree class
- InOrder()
- PreOrder()
- PostOrder()
