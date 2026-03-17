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
// Time Complexity: O(n)
