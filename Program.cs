using System;

namespace Array_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = {1.5f,2.6f,3.7f,4.3f,5f,6,7f,8f};
            for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
            Console.WriteLine(ArrayHelper.UnShift(ref arr,6.0008f));
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
        public static int Shift(ref int[] arr)
        {
            int n = arr[0];
            for (int i = 0;i <arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static string Shift(ref string[] arr)
        {
            string n = arr[0];
            for (int i = 0;i <arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static double Shift(ref double[] arr)
        {
            double n = arr[0];
            for (int i = 0;i <arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            decimal n = arr[0];
            for (int i = 0;i <arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static float Shift(ref float[] arr)
        {
            float n = arr[0];
            for (int i = 0;i <arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            Array.Resize(ref arr, arr.Length-1);
            return n;
        }
        public static int UnShift(ref int[] arr, int var)
        {
            int a, b, c=arr[arr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    a = arr[i];
                    arr[i] = var;
                    for (int j=i+1; j<arr.Length-1; j=j+2)
                    {
                        b = arr[j];
                        arr[j]=a;
                        a=arr[j+1];
                        arr[j+1] = b;                  
                    }
                    arr[arr.Length-1]=c;
                }
            }
            return arr.Length;
        }
        public static string UnShift(ref string[] arr, string var)
        {
            string a, b, c=arr[arr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    a = arr[i];
                    arr[i] = var;
                    for (int j=i+1; j<arr.Length-1; j=j+2)
                    {
                        b = arr[j];
                        arr[j]=a;
                        a=arr[j+1];
                        arr[j+1] = b;                  
                    }
                    arr[arr.Length-1]=c;
                }
            }
            return Convert.ToString(arr.Length);
        }
        public static double UnShift(ref double[] arr, double var)
        {
            double a, b, c=arr[arr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    a = arr[i];
                    arr[i] = var;
                    for (int j=i+1; j<arr.Length-1; j=j+2)
                    {
                        b = arr[j];
                        arr[j]=a;
                        a=arr[j+1];
                        arr[j+1] = b;                  
                    }
                    arr[arr.Length-1]=c;
                }
            }
            return arr.Length;
        }
        public static decimal UnShift(ref decimal[] arr, decimal var)
        {
            decimal a, b, c=arr[arr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    a = arr[i];
                    arr[i] = var;
                    for (int j=i+1; j<arr.Length-1; j=j+2)
                    {
                        b = arr[j];
                        arr[j]=a;
                        a=arr[j+1];
                        arr[j+1] = b;                  
                    }
                    arr[arr.Length-1]=c;
                }
            }
            return arr.Length;
        }
        public static float UnShift(ref float[] arr, float var)
        {
            float a, b, c=arr[arr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    a = arr[i];
                    arr[i] = var;
                    for (int j=i+1; j<arr.Length-1; j=j+2)
                    {
                        b = arr[j];
                        arr[j]=a;
                        a=arr[j+1];
                        arr[j+1] = b;                  
                    }
                    arr[arr.Length-1]=c;
                }
            }
            return arr.Length;
        }
    }
}
