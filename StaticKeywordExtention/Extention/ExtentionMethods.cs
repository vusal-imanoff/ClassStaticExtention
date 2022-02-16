using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeywordExtention.Extention
{
    static class ExtentionMethods
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static int[] GetValueIndexes(this string text, char temp)
        {
            int[] arr = new int[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == temp)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }


            }

            return arr;
        }

    }
}
