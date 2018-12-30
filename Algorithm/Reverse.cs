using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class ReverseChars
    {
        public static void Reverse(char[] arrayOfChars)
        {
            int leftIndex = 0;
            int rightIndex = arrayOfChars.Length - 1;

            while (leftIndex < rightIndex)
            {
                // set temp holder
                var temp = arrayOfChars[leftIndex];

                // assign leftindex val with rightindex value
                arrayOfChars[leftIndex] = arrayOfChars[rightIndex];

                // assign rightindex val with temp.
                arrayOfChars[rightIndex] = temp;

                // increment and decrement by 1
                leftIndex++;
                rightIndex--;
            }
        }
    }
}
