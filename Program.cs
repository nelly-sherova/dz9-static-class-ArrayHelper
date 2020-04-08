using System;

namespace Array_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = {1.3f,2.5f,3.9f,4.0009f};
            for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
            Console.WriteLine(ArrayHelper.Push(ref arr, 7.009f) );
            for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
        }
    }
    static class ArrayHelper
    {
        public static int Pop(ref int[] arr)
        {
            int n = arr[arr.Length-1];
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static string Pop(ref string[] arr)
        {
            string n = arr[arr.Length-1];
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static double Pop(ref double[] arr)
        {
            double n = arr[arr.Length-1];
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static decimal Pop(ref decimal[] arr)
        {
            decimal n = arr[arr.Length-1];
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static float Pop(ref float[] arr)
        {
            float n = arr[arr.Length-1];
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static int Push(ref int[] arr, int var)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = var;
            return arr.Length;
        }
        public static string Push(ref string[] arr, string var)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = var;
            return Convert.ToString(arr.Length);
        }
        public static double Push(ref double[] arr, double var)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = var;
            return arr.Length;
        }
        public static decimal Push(ref decimal[] arr, decimal var)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = var;
            return arr.Length;
        }
        public static float Push(ref float[] arr, float var)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = var;
            return arr.Length;
        }
    }
}
