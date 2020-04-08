using System;

namespace Array_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            // для проверки int
            /*{
                int[] arr1 = {1,2,3,4,5,6,7,8};
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ваш массив типа int: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Pop: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Pop(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Push: ");
                Console.WriteLine("Введите элемент которого хотите добавить в конец массива:");
                int var1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.Push(ref arr1, var1)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Shift: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Shift(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода UnShift: ");
                Console.WriteLine("Введите элемент которого хотите добавить в начало массива:");
                int var2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.UnShift(ref arr1, var2)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
            }*/
            // для проверки string
            {
                string[] arr1 = {"Кошка","Собака","Зебра","Крокодил","Лев"};
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВаш массив типа string: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Pop: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Pop(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Push: ");
                Console.WriteLine("Введите элемент которого хотите добавить в конец массива:");
                string var1 = Console.ReadLine();
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.Push(ref arr1, var1)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Shift: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Shift(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода UnShift: ");
                Console.WriteLine("Введите элемент которого хотите добавить в начало массива:");
                string var2 = Console.ReadLine();
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.UnShift(ref arr1, var2)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
            
            }
            // для проверки double
            /*{
                double[] arr1 = {1.3,2,3,4.5,5,6.7,7,8.0006};
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nВаш массив типа double: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Pop: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Pop(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Push: ");
                Console.WriteLine("Введите элемент которого хотите добавить в конец массива:");
                double var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.Push(ref arr1, var1)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Shift: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Shift(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода UnShift: ");
                Console.WriteLine("Введите элемент которого хотите добавить в начало массива:");
                double var2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.UnShift(ref arr1, var2)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
            }*/
            // для проверки decimal
            /*{
                decimal[] arr1 = {1m,2.01m,3.03m,4.4m,5m,6m,7.7m,8.08m};
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nВаш массив типа decimal: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Pop: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Pop(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Push: ");
                Console.WriteLine("Введите элемент которого хотите добавить в конец массива:");
                decimal var1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.Push(ref arr1, var1)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Shift: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Shift(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода UnShift: ");
                Console.WriteLine("Введите элемент которого хотите добавить в начало массива:");
                decimal var2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.UnShift(ref arr1, var2)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
            }*/
            //для проверки float
            /*{
                float[] arr1 = {1f,2f,3f,4.007f,5f,6f,7.009f,8f};
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nВаш массив типа float: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Pop: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Pop(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Push: ");
                Console.WriteLine("Введите элемент которого хотите добавить в конец массива:");
                float var1 = float.Parse(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.Push(ref arr1, var1)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода Shift: ");
                Console.WriteLine($"Удалили: {ArrayHelper.Shift(ref arr1)}");
                Console.Write("Осталось: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
                Console.WriteLine("\nВаш массив после использования метода UnShift: ");
                Console.WriteLine("Введите элемент которого хотите добавить в начало массива:");
                float var2 = float.Parse(Console.ReadLine());
                Console.WriteLine($"Новый размер вашего массива: {ArrayHelper.UnShift(ref arr1, var2)}");
                Console.Write("Стало: ");
                for (int i = 0; i < arr1.Length; i++) Console.Write($"{arr1[i]}  ");
            }*/
            Console.ForegroundColor = ConsoleColor.White;
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
