using System;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[] { 7, 1, 3, 2, 4, 5, 6 };
            //ArraysAndStrings.ReverseArray(a);
            //ArraysAndStrings.ReverseWordsISentence(new char[] { 't', 'h', 'i', 's', ' ', 'i', 's', ' ', 'g', 'o', 'o', 'd' });
            //ArraysAndStrings.RemoveElement(a, 3);
            ArraysAndStrings.MinimumSwaps(a);
        }
    }
}
