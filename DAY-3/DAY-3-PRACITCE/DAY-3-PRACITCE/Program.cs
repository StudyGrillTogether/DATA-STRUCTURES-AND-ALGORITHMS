using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_PRACITCE
{
    internal class Program
    {
        static int LinearSearch(int[] array,int target)
        {
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] == target)
                {
                    return i;
                }
                
            }
            return -1;
        }

        static int BinarySearch(int[] array,int target)
        {
            int left = 0;
            int right=array.Length-1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }
            return -1;
        }

        static int[] Insert(int[] array, int position,int value)
        {
            int[] newArray= new int[array.Length+1];
            for(int i = 0; i < position; i++)
            {
                newArray[i] = array[i];
            }
            newArray[position] = value;
            for(int i = position + 1; i < newArray.Length; i++)
            {
                newArray [i] = array [i-1];
            }
            return newArray;
        }

        static int[] Delete(int[] array,int position)
        {
            
            int[] newArray=new int[array.Length-1];
            for (int i = 0; i < position; i++)
            {
                newArray[i] = array[i];
            }
            
            for (int i = position; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of elemennts in your array");
            int n=int.Parse(Console.ReadLine());
            int[] MyArray = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"Enter Element{i + 1}:");
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter the element you want to search");
            int findNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(LinearSearch(MyArray, findNumber));

            int[] array1 = Insert(MyArray, 2, 13);
            foreach(int i in array1)
            {
                Console.Write(i+" ");
            }

            int[] array2 = Delete(array1, 2);
            Console.WriteLine();
            foreach (int i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nUSING bINARY sEARCH");
            Array.Sort(MyArray);
            Console.WriteLine(BinarySearch(MyArray, findNumber)); 
        }


    }
}
