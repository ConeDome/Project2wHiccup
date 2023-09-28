using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class MergeSort<T> : ISort<T> where T: IComparable<T>
    {
        public void Sort(List<T> stuff)
        { 
        
        }
        static void Merge(int[] arr, int leftBound, int middle, int rightBound)
        {
            int length1 = middle - leftBound + 1;
            int length2 = rightBound - middle;

            int[] leftArray = new int[length1];
            int[] rightArray = new int[length2];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = leftBound;

            for (int i = 0; i < length1; i++)
            {
                leftArray[i] = arr[leftBound + i];
            }
            for (int j = 0; j < length2; j++)
            {
                rightArray[j] = arr[middle + 1 + j];
            }


            while (leftIndex < length1 && rightIndex < length2)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    arr[mergedIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[mergedIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < length1)
            {
                arr[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < length2)
            {
                arr[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
                mergedIndex++;
            }

        }
    }


}
