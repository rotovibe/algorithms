using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class ReverseWords
    {
        public static char[] ReverseAllWords(char[] phrase)
        {
            int lIndex = 0;
            int rIndex = phrase.Length - 1;

            if (rIndex > 1)
            {
                // reverse complete phrase
                phrase = ReverseString(phrase, 0, rIndex);

                // reverse each word
                for (int r = 0; r <= phrase.Length; r++)
                {
                    // check for the end of the word.
                    if (r == phrase.Length || phrase[r] == ' ')
                    {
                        // trim the space at the end of the word and adjust the index location by -1
                        phrase = ReverseString(phrase, lIndex, r - 1);
                        // move to next position to skip over the space.
                        lIndex = r + 1;
                    }
                }
            }

            return phrase;
        }

        static char[] ReverseString(char[] arr, int lIndex, int rIndex)
        {
            char temp;
            while (lIndex < rIndex)
            {
                temp = arr[lIndex];
                arr[lIndex++] = arr[rIndex];
                arr[rIndex--] = temp;
            }

            return arr;
        }
    }
}
