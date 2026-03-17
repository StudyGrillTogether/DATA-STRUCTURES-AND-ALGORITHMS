using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_PRACTICE_BIG_O_
{
    internal class Program
    {
        // this has linear complexity O(n)
        void PrintFirstAndAll(int[] array)
        {
            Console.WriteLine(array[0]);
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array [i]);
            }
        }
       //Binarry search -check the middle element or find the 
       static int BinarySearch(int[] array,int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid=(left+right)/2;
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid+1;
                }
                else
                {
                    right = mid-1;
                }
            }
            return -1;
        }

        //this hhas logarithmic complexity since for each input it divides the operations 
        // in halves 

        
        static void Main(string[] args)
        {
            //0(1) EXAMPLE -constant time
            //accesing an array element  by index
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(array[0]);

            //O(n^2) loop inside loop exxample 
            for (int i= 0; i < array.Length; i++)
            {
                for(int j=0; j < array.Length; j++)
                {
                    Console.WriteLine(array[i]+" "+ array[j]);
                }
            }
           Console.WriteLine(BinarySearch(array, 6));
            
        }
    }
}
