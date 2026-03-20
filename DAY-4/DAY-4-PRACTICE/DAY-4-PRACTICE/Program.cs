using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_PRACTICE
{
    internal class Program
    {
        class Node
        {
            public int data; //stores value
            public Node next; //points to the next node
        }
        class LinkedList
        {
             Node head; //points to first node

            public void AddFirst(int value)
            {
                Node firstNode=new Node();
                firstNode.data = value;
                firstNode.next = head;
                head = firstNode;
                
            }
            /// <summary>
            /// we created the new node using class node
            /// stored the data in it
            /// then pointed that new nodes pointer to the node before we are adding that is head node 
            /// and updated the value of head with new node thus implying that first node is now new node
            /// thus completing the operation of the addfirst method
            /// </summary>
            /// <param name="args"></param>
            public void AddLast(int value)
            {
                Node newNode=new Node();
                newNode.data = value;
                newNode.next = null;

                if (head == null)
                {
                    head = newNode;
                    return;
                }
                //traversing the list
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }
            ///in this first we create a new node 
            ///then make the data of it to the value and make its pointer ull since we are adding it to the last
            ///then we check a condition that if the list is empty and if it is we make the newnode head
            ///now we want to update the pointer of current last node so that it points toward our new last node
            ///so to find the current last node we traverse 
            ///we use current as a temporary pointer to traverse the list without losing the head
            ///so we loop using the while loop and find the current last node
            ///then we upadtes it pointer to our new last node that is here new node thus completing the operation
            
            public void Display()
            {
                if (head == null)
                {
                    Console.WriteLine("The list is empty:");
                    return;
                }
                else
                {
                    Node current = head;
                    while (current!= null)
                    {
                        Console.WriteLine(current.data+" -> ");
                        current = current.next;
                    }
                }
            }
        }
        
        
        static void Main(string[] args)
        {
            LinkedList list=new LinkedList();
            
            Console.WriteLine("1.ADD A VALUE at the start of LIST");
            Console.WriteLine("2.Add node at the last of the list");
            Console.WriteLine("3.Display the list");
            Console.WriteLine("4.Exit");
            
            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter your choice: ");
                string choice=Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("enter the value you want to add: ");
                        int value = int.Parse(Console.ReadLine());
                        list.AddFirst(value);
                        break;
                    case "2":
                        Console.WriteLine("enter the value you want to add: ");
                        int value2 = int.Parse(Console.ReadLine());
                        list.AddLast(value2);
                        break;
                    case "3":
                        list.Display();
                        break;
                    case "4":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Invalid INPUT!");
                        return;
                        break;

                }
            }
        }
    }
}
