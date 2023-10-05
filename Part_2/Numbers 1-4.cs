using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class Numbers
    {
      
        public static void Main(string[] args)
        {
            Console.WriteLine("Номер 1. Смена элементов массива\n");


            Random rnd = new Random();
            int[] arrayForRandomNumbers = new int[20];
            for (int i = 0; i < arrayForRandomNumbers.Length; i++)
            {
                arrayForRandomNumbers[i] = rnd.Next(1, 101);
            }
            Console.WriteLine("Изначальный массив равен:");
            foreach (int i in arrayForRandomNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nВведите первое чсило.");
            int.TryParse(Console.ReadLine(), out int firstNumberFromArray);
            Console.WriteLine("Введите второе число.");
            int.TryParse(Console.ReadLine(), out int secondNumberFromArray);

            if (firstNumberFromArray >= 0 && secondNumberFromArray >= 0 && firstNumberFromArray <= 19 && secondNumberFromArray <= 19)
            {
                Console.WriteLine("\nНовый массив равен:");
                (arrayForRandomNumbers[firstNumberFromArray], arrayForRandomNumbers[secondNumberFromArray]) = (arrayForRandomNumbers[secondNumberFromArray], arrayForRandomNumbers[firstNumberFromArray]);
                foreach (int i in arrayForRandomNumbers)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear() ;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели несуществующий индекс массива.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
