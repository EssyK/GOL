using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    public static class ArraysAndStrings
    {
        public static void ReverseArray(int[] a)
        {
            if(ReferenceEquals(a,null) || a.Length == 0) return;
            int n = a.Length - 1;
            int i = 0;

            while (i <= n)
            {
                int temp = a[i];
                a[i++] = a[n];
                a[n--] = temp;
            }
            PrintInArray(a, 0, a.Length - 1);
        }

        public static void ReverseWordsISentence(char[] a)
        {
            if (a.Length == 0) return;

            //reverse the whole array
            reverseArray(0, a.Length - 1, a);
            int startIndex = 0;

            for(int i = 0; i < a.Length; i++)
            {
                if (!char.IsLetterOrDigit(a[i])) {
                    reverseArray(startIndex,i-1,a);
                    startIndex = i + 1;
                }
            }

            reverseArray(startIndex, a.Length - 1, a);

            foreach (var number in a)
            {
                Console.Write(number);
            }
        }

        static void reverseArray(int startIndex,int endIndex, char[] a)
        {
            while (startIndex <= endIndex)
            {
                char temp = a[startIndex];
                a[startIndex++] = a[endIndex];
                a[endIndex--] = temp;
            }
        }

        public static void MinimumSwaps(int[] a)
        {
            if (a.Length == 0) return;
            int midIndex = a.Length / 2;
            int midVal = a[midIndex];
            for (int i = 0; i < a.Length; i++)
            {                
                if (a[i] < a[midIndex])
                {
                    Swap(a, i, midIndex);
                    break;
                }
            }
            PrintInArray(a, 0, a.Length - 1);
        }

        static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int k = 0;//index tracking the position of the remaining elements

            for (int i = 0; i < nums.Length; i++)
            {                
                if (nums[i] != val)//get only the desired elements
                {
                    nums[k++] = nums[i];
                }
            }
            PrintInArray(nums, 0, k-1);
            return k;
        }

        static void PrintInArray(int[] a, int startIndex, int endIndex)
        {
            for(int i=startIndex;i<=endIndex;i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
