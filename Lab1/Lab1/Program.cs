using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
         
        {
            //Вывести на экран полученные данные
            Console.Write("Полученные данные: ");
            Console.WriteLine(args[0]);
            
            //Запросить у пользователя число для поиска
            Console.Write("Введите число для поиска: ");
            int a = Int32.Parse(Console.ReadLine());
            
            //Разбить строку на массив строк(тип данных String[])
            String[] string_arr;
            string_arr = args[0].Split('-');
            
            //Создать массив чисел(тип данных Int32[])
            int length = string_arr.Length;
            Int32[] int_arr;
            int_arr = new int[length];
            
            //Используя цикл for преобразовать массив строк в массив чисел
            for (int i = 0; i < length - 1; i++)
            {
                int_arr[i] = Int32.Parse(string_arr[i]);
            }
            
            //Создать дополнительные переменные для хранения результатов алгоритма
            int max = int_arr[0];
            int max_index = 0;
            int min = int_arr[0];
            int min_index = 0;
            int result = 0;
            int result_index = -1;
            
            //Используя цикл for произвести поиск элементов массива
            for (int i = 0; i < length - 1; i++)
            {
                if (int_arr[i] > max)
                {
                    max = int_arr[i];
                    max_index = i;
                }

                if (int_arr[i] < min)
                {
                    min = int_arr[i];
                    min_index = i;
                }

                if (int_arr[i] == a)
                {
                    result = int_arr[i];
                    result_index = i;
                }
            }

            //Результаты вывести на экран
            Console.Write("Индекс максимального элемента в массиве: ");
            Console.WriteLine(max_index);

            Console.Write("Индекс минимального элемента в массиве: ");
            Console.WriteLine(min_index);

            Console.Write("Индекс указанного элемента в массиве: ");
            if (result_index != -1)
            {
                Console.WriteLine(result_index);
            }
            else
            {
                Console.WriteLine("не найден");
            }

            Console.ReadLine();
        }
    }
}
