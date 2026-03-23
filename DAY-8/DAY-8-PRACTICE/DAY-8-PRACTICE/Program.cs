using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_8_PRACTICE
{
    internal class Program
    {
        static int LinearSearch(int[] array,int target)
        {
            for(int i=0;i<array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        static int BinarySearch(int[] array,int target)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length-1;
            while (left <= right)
            {
                int mid=(left+right)/2;
                if (array[mid] == target)
                {
                    return mid;
                }
                else if(array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of element in array");
            int n=int.Parse(Console.ReadLine());
            int[] myArray= new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"ENTER ELEMENT  {i + 1}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the number you want to search in array:");
            int target = int.Parse((Console.ReadLine()));
            Console.WriteLine($"linear seach : index {LinearSearch(myArray, target)}");
            Console.WriteLine($"binary search :index {BinarySearch(myArray,target)}");
        }
    }
}
