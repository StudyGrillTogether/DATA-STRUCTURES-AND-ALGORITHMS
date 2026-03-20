using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_GIT_EXERCISE
{
    internal class Program
    {
        class MyStack
        {
            int[] array;//aray to store elements
            int top; //index of the top element
            int size; //max size of the stack 
            public MyStack(int size)
            {
                this.size = size;
                this.array = new int[size];
                this.top = -1;


            }
            /// <summary>
            /// here we first created an array to store elements then 
            /// intitialized top as the index of top elements 
            /// tjem size as to intialize array so what is its max size
            /// then in constructor we initialized the variables/fields 
            /// size as the size passed when creating an object and array with that size 
            /// and top starting with -1 that is the stack is empty at first
            /// </summary>
            /// <param name="args"></param>
            public void Push(int value)
            {
                if (top == size - 1)
                {
                    throw new ArgumentException("The stack is full");
                }
                top++;
                array[top] = value;
            }
            /// <summary>
            ///  in this we check if the stack is full via if condition 
            ///  then increment top index and store the value in that array index 
            /// </summary>
            /// <returns></returns>
            /// <exception cref="ArgumentException"></exception>
            public int Pop()
            {
                if (top == -1)
                {
                    throw new ArgumentException("the stack is empty");
                }
                int temp = array[top];
                top--;
                return temp;
            }
            /// <summary>
            /// in this we check if the array is empty 
            /// if not we store the top index element in a temp variable
            /// then we decrement the value of top 
            /// point to remember we are not removing the top element just moving the index value 
            /// sp we are just ignoring the pop value since its still in array
            /// since in next push opeartion it will be overwritten
            /// </summary>
            /// <returns></returns>
            /// <exception cref="ArgumentException"></exception>
            public int Peek()
            {
                if (top == -1)
                {
                    throw new ArgumentException("the stack is empty");
                }
                return array[top];
            }
            public bool IsEmpty()
            {
                return top == -1;
            }
            public void Display()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                MyStack temp = new MyStack(size);
                while (!IsEmpty())
                {
                    int val = Pop();
                    Console.WriteLine(val+" ");
                    temp.Push(val);
                }

                //restore orignal stack
                while (!temp.IsEmpty())
                {
                    Push(temp.Pop());
                }
            }
            /// in the display mmethod we create a temp stack then we pop from the orignal 
            /// but while popping in each loop we store it in temp stack 
            /// after the popping and printing is done 
            /// we op form temp stack and push it in the orignal stack 
            /// 
            
        }
        public static string ReverseString(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                stack.Push(c);
            }
            string reverse = "";
            while (stack.Count != 0)
            {
                reverse += stack.Pop();
            }
            return reverse;
        }

        public static bool IsBalanced(string input)
        {
            Stack<char> stack=new Stack<char>();
            foreach(char c in input)
            {

                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char cin=stack.Pop();
                    if (!( (cin == '(' && c == ')') ||
                        (cin == '{' && c == '}') ||
                        (cin == '[' && c == ']')))
                    {
                        return false;
                    }

                }
            }
            return stack.Count==0;
        }
        /// <summary>
        /// so we take an input inside the method itself ofc and the method is bool so we return true or false
        /// inside method we take a local stack 
        /// then using if we check the conditions of open paranthesis if they are open paranthesis
        /// then we push it inside the stack
        /// now after pushing uing else if condition for close paranthesis we apply the pop function of stack
        /// if close paranthesesis we apply pop function
        /// if the popped opening bracket does not match the current closing bracket — for example ( should match ) — we return false immediately"
        /// like for ex (==) then we return false we do this for every paranthesis until stack is empty or we get false 
        /// as return 
        /// then at last we check if stack is empty if it is then it returns true and we check if 
        /// the paranthesis are balanced
        /// and before popping we also check if the stack is empty ort not 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(5);
            Console.WriteLine("1.enter a new number in stack");
            Console.WriteLine("2.pop from the stack");
            Console.WriteLine("3.peek in the stack");
            Console.WriteLine("4.check of the stack is empty or not");
            Console.WriteLine("5.display stack");
            Console.WriteLine("6.Reverse a string");
            Console.WriteLine("7. check if balanced paranthesis");
            Console.WriteLine("8.Exit");
            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter your choice:");
                string choice=Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the number you want in stack: ");
                        int num=int.Parse(Console.ReadLine());
                        stack.Push(num);
                        break;
                    case "2":
                        Console.WriteLine($"The number popped is {stack.Pop()}");
                        break;
                    case "3":
                        Console.WriteLine($"THE peeked number from stack is: {stack.Peek()}");
                        break;
                    case "4":
                        Console.WriteLine($"THE stack is empty is: {stack.IsEmpty()}");
                        break;
                    case "5":
                        stack.Display();
                        break;
                        
                    case "6":
                        Console.WriteLine("Enter a string to reverse:");
                        string input= Console.ReadLine();
                        Console.WriteLine(ReverseString(input));
                        break;
                    case "7":
                        Console.WriteLine("enter the paranthesis to check if balanced");
                        string paranthesis=Console.ReadLine();
                        Console.WriteLine($"the paranthesis is balanced:{IsBalanced(paranthesis)}");
                        break;
                    case "8":
                        run = false; break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;

                }
            }
        }
    }
}
