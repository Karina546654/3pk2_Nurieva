using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace pz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); 
            int[] arr = new int[5000];   // массив
            List<int> list = new List<int>();   // список данных
            
            for (int j = 0; j < arr.Length; j++)      // заполнение рандомными числами
            {
                int random = rand.Next(1, 1000);
                arr[j] = random;      //заполнение массива
                list.Add(random);       //заполнение списка
            }

            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine($"Ввод числа для поиска: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("1) прямой поиск");
            Console.WriteLine($"в массиве: ");

            stopWatch.Start();

            int i = 0;
            while (i < arr.Length && arr[i] != a)
            {
                i++;
                if (i < arr.Length)
                {
                    Console.WriteLine($"{a} нашлось");
                    break;
                }
                else
                {
                    Console.WriteLine($"{a} не нашлось");
                    break;
                }
            }
            stopWatch.Stop();
            Console.WriteLine($"stopwatch: {stopWatch.Elapsed}\n");
            stopWatch.Reset();

            Console.WriteLine($"в списке:");
            stopWatch.Start();

            i = 0;
            while (i < list.Count && list[i] != a)
            {
                i++;
                if (i < list.Count)
                {
                    Console.WriteLine($"{a} нашлось");
                    break;
                }
                else
                {
                    Console.WriteLine($"{a} не нашлось");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}\n");
            stopWatch.Reset();

            Console.WriteLine("2)бинарный поиск");

            Console.WriteLine($"в массиве:");
            stopWatch.Start();

            int middle, left = 0, right = arr.Length - 1;
            middle = (left + right) / 2;
            if (a > arr.Length)
                left = middle + 1;
            else
                right = middle - 1;
            while ((arr[middle] != a) && (left <= right))
            {
                if (arr[middle] == a)
                {
                    Console.WriteLine($"{a} нашлось");
                    break;
                }
                else
                {
                    Console.WriteLine($"{a} не нашлось");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}\n");
            stopWatch.Reset();
           
            Console.WriteLine($"в списке: ");
            stopWatch.Start();

            left = 0;
            right = list.Count - 1;
            middle = (left + right) / 2;
            if (a > list.Count)
                left = middle + 1;
            else
                right = middle - 1;
            while ((list[middle] != a) && (left <= right))
            {
                if (list[middle] == a)
                {
                    Console.WriteLine($"{a} нашлось");
                    break;
                }
                else
                {
                    Console.WriteLine($"{a} не нашлось");
                    break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"Stopwatch: {stopWatch.Elapsed}");
           
        }
    }
}
  