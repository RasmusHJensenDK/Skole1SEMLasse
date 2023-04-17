using System.Collections.Specialized;
using System.Text;
using System;
using System.Linq;

namespace MyNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] d = { 1, 3, 2, 7, 5 };
            int[] e = { 1, 2, 3, 4 };
            int[] f = { 5, 6, 7 };

            Console.WriteLine(string.Join(",", Mult(e, 5)));
            Console.WriteLine(string.Join(",", SetSammen(e, f)));
            Console.WriteLine(string.Join(",", SetSammenToKommaNul(e, f)));

            //Advanced
            Console.WriteLine(string.Join(",", Extension.Concat(e, f)));
        }
        //Linq Select
        public static int[] Mult(int[] a, int b)
        {
            int[] returnArr = a.Select(c => c * b).ToArray();
            return returnArr;
        }
        //Linq Union
        public static int[] SetSammen(int[] A, int[] B)
        {
            int[] returnArr = A.Union(B).ToArray();
            return returnArr;
        }
        //Linq Concat
        public static int[] SetSammenToKommaNul(int[] A, int[] B)
        {
            //int[] returnArr = new int[A.Length + B.Length];
            int[] returnArr = A.Concat(B).ToArray();
            return returnArr;
        }
    }
    //Advanced
    public static class Extension
    {
        public static T[] Concat<T>(this T[] first, params T[] second)
        {
            T[] result = new T[first.Length + second.Length];
            first.CopyTo(result, 0);
            second.CopyTo(result, first.Length);
            return result;
        }
    }
}
