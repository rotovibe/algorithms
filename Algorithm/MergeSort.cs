using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class MergeSort
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            var count1 = arr1.Length;
            var count2 = arr2.Length;
            // set merged array dimension
            var mArray = new int[count1 + count2];

            int c1 = 0;
            int c2 = 0;
            int mArr = 0;

            // join arrays
            while (c1 < count1 && c2 < count2)
            {
                if (arr1[c1] <= arr2[c2])
                {
                    mArray[mArr++] = arr1[c1++];
                }
                else
                {
                    mArray[mArr++] = arr2[c2++];
                }
            }

            // tail
            if (c1 < count1)
            {
                // fill tail from first array
                for (int j = c1; j < count1; j++)
                {
                    mArray[mArr++] = arr1[j];
                }
            }
            else
            {
                // fill tail from second array
                for (int j = c2; j < count2; j++)
                {
                    mArray[mArr++] = arr2[j];
                }
            }

            return mArray;
        }
    }
}
