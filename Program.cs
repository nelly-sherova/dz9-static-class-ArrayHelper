using System;

namespace Array_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
    }
}
