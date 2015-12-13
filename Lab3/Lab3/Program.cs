using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
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

            //Создать список (List<int>) чисел(тип данных int[]) для хранения сортированных данных
            var int_list = new List<int>();

            //Далее необходимо реализовать процедуру сортировки для этого необходимо
            //использовать 2 цикла: один цикл вложен в другой. Для вставки чисел в 
            //список использовать метод List<T>.Insert(…)
            for (int i = 0; i < length - 1; i++)
            {
                int temp = int_arr[i];
                int j = i - 1;
                while (j >= 0 && int_arr[j] > temp)
                {
                    int_arr[j + 1] = int_arr[j];
                    j--;
                }
                int_arr[j + 1] = temp;
            }
            //Вносим сортированные данные в список
            for (int i = 0; i < length - 1; i++)
            {
                int_list.Insert(i, int_arr[i]);
            }

            //Результирующий список вывести на экран
            for (int i = 0; i < length - 1; i++)
            {
                Console.WriteLine(int_list[i]);
            }
            Console.ReadLine();
        }
    }
}
