using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_10_PRACTICE
{
    internal class Program
    {
        static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            else
            {
                int middle=(array.Length) /2;
                int[] left= new int[middle];
                int[] right=new int[array.Length-middle];
                for(int i = 0; i < middle; i++)
                {
                    left[i]=array[i];
                }
                for(int i=middle; i<array.Length; i++)
                {
                    right[i-middle]=array[i];
                }
                left=MergeSort(left);
                right=MergeSort(right);
                return Merge(left, right);
            }
        }
        static int[] Merge(int[] left , int[] right)
        {
            int[] result=new int[left.Length+right.Length];
            int i = 0, j = 0, k = 0;
            while(i<left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++]=left[i++]; ///take from left
                else
                    result[k++]=right[j++]; //take from right
            }

            //copying remaining elemenents
            while(i<left.Length) result[k++]=left[i++];
            while(j<right.Length) result[k++]=right[j++];

            return result;
        }

        static void QuickSort(int[] array,int low,int high)
        {
            if (low >= high)
            {
                return;
            }
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex-1);
            QuickSort(array, pivotIndex + 1, high);
        }
        static int Partition(int[] array,int low,int high)
        {
            int pivot = array[high];
            int i= low - 1;
            
            for(int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i = i + 1;
                    int temp1 = array[i];
                    array[i] = array[j];
                    array[j] = temp1;                    
                }              
            }
            int temp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp;
            return i + 1;
        }
        
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 2, 8, 1 };
            int[] sortarray=MergeSort(array);
            foreach(int i in sortarray)
            {
                Console.WriteLine(i);
            }
            QuickSort(array, 0, array.Length - 1);
            foreach(int n in array)
                Console.WriteLine(n+" ");   
        }
    }
}
