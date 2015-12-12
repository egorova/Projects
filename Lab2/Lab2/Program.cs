using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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
            string_arr = args[0].Split('*');

            //Создать массив чисел(тип данных Int32[])
            int length = string_arr.Length;
            Int32[] int_arr;
            int_arr = new int[length];

            //Используя цикл for преобразовать массив строк в массив чисел
            for (int i = 0; i < length - 1; i++)
            {
                int_arr[i] = Int32.Parse(string_arr[i]);
            }

            //Бинарный поиск
            int position = -1;
            int min_index = 0;
            int max_index = length;
            while (min_index != max_index)
            {
                position = (min_index + max_index) / 2;
                if (int_arr[position] == a)
                {
                    min_index = max_index;
                }
                else
                {
                    if (int_arr[position] < a)
                    {
                        min_index = position + 1;
                    }
                    else
                    {
                        max_index = position;
                    }
                    position = -1;
                }
            }
            Console.Write("Индекс указанного элемента в массиве: ");
            if (position != -1)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("не найден");
            }
            Console.ReadLine();
        }
    }
}
