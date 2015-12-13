using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести на экран полученные данные
            Console.Write("Полученные данные: ");
            Console.WriteLine(args[0]);

            //Разбить строку на массив строк(тип данных String[])
            String[] string_arr;
            string_arr = args[0].Split('.');

            //Создать массив чисел(тип данных Int32[])
            int length = string_arr.Length;
            Int32[] int_arr1;
            Int32[] int_arr2;
            int_arr1 = new int[length];
            int_arr2 = new int[length];

            //Используя цикл for преобразовать массив строк в массив чисел
            for (int i = 0; i < length - 1; i++)
            {
                int_arr1[i] = Int32.Parse(string_arr[i]);
                int_arr2[i] = Int32.Parse(string_arr[i]);
            }

            //Создать и запустить секундомер "Stopwatch"
            Stopwatch watch = new Stopwatch();
            watch.Start();

            //Выполнить сортировку вставками
            for (int j = 2; j < length - 1; j++)
            {
                int key = int_arr1[j];
                int i = j - 1;
                while (i > 0 && int_arr1[i] > key)
                {
                    int_arr1[i + 1] = int_arr1[i];
                    i = i - 1;
                    int_arr1[i + 1] = key;
                }
            }

            //Остановить секундомер. Запомнить время выполнения
            watch.Stop();
            long time1 = watch.ElapsedTicks;

            //Сбросить и запустить секундомер
            watch.Reset();
            watch.Start();

            //Выполнить сортировку пузырьком
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (int_arr2[j] > int_arr2[j + 1])
                    {
                        int b = int_arr2[j]; //change for elements
                        int_arr2[j] = int_arr2[j + 1];
                        int_arr2[j + 1] = b;
                    }
                }
            }

            //Остановить секундомер. Запомнить время выполнения
            watch.Stop();
            long time2 = watch.ElapsedTicks;

            //Результирующий список вывести на экран, указать время сортировок
            for (int i = 0; i < length - 1; i++)
            {
                Console.WriteLine(int_arr1[i]);
            }

            for (int i = 0; i < length - 1; i++)
            {
                Console.WriteLine(int_arr1[i]);
            }

            Console.WriteLine("Время выполнения сортировки вставками: ", time1);
            Console.WriteLine("Время выполнения сортировки пузырьком: ", time2);

            Console.ReadLine();
        }
    }
}
