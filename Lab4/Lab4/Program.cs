using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
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
            Int32[] int_arr;
            int_arr = new int[length];

            //Используя цикл for преобразовать массив строк в массив чисел
            for (int i = 0; i < length - 1; i++)
            {
                int_arr[i] = Int32.Parse(string_arr[i]);
            }

            //Создать и запустить секундомер "Stopwatch"
            Stopwatch watch = new Stopwatch();
            watch.Start();

            //Далее необходимо реализовать процедуру сортировки в одном цикле
            //для этого необходимо использовать цикл: «while».
            //Цикл прекращается (команда «break»), как только отсутствуют обмены при итерации.
            int ii = 0, temp, x = 0 , y = 0;
            while (x < int_arr.Length * int_arr.Length)
            {
                if (int_arr[ii + 1] < int_arr[ii])
                {
                    temp = int_arr[ii];
                    int_arr[ii] = int_arr[ii + 1];
                    int_arr[ii + 1] = temp;
                    y++;
                }
                if (ii < int_arr.Length -2) ii++;
                else
                {
                  ii = 0;
                  if(y == 0 ) break;
                }
                x++;
                
            }

            //Останавливаем секундомер
            watch.Stop();

            //Результирующий список вывести на экран, указать время секундомера.
            Console.WriteLine("Время затраченное на сортировку: {0}", watch.ElapsedTicks);

            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write("{0} ", int_arr[i]);
            }
            Console.ReadLine();
        }
    }
}
