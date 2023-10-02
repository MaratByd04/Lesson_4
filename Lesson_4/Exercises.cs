using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    internal class Exercises
    {
            
            static int LargerOfTwoNumbers(int firstNumber, int secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("Наибольшее из чисел = " + firstNumber);
                    return firstNumber;
                }
                else
                {
                    Console.WriteLine("Наибольшее из чисел = " + secondNumber);
                    return secondNumber;
                }


            }
            
        static void Main(string[] args)
        {
                Console.WriteLine("Проверка Упражнения 5.1. Наибольшее из двух целых чисел.\n");


                Console.WriteLine("Введите первое число.");
                int.TryParse(Console.ReadLine(), out int firstNumber);
                Console.WriteLine("Введите второе число.");
                int.TryParse(Console.ReadLine(), out int secondNumber);
                LargerOfTwoNumbers(firstNumber, secondNumber);


                Console.WriteLine("\n\nУпражнение 5.2. Смена двух чисел.\n");


                Console.WriteLine("Введите первое число.");
                int firstVariable = int.Parse(Console.ReadLine());
                Console.WriteLine("Введиет второе число.");
                int secondVariable = int.Parse(Console.ReadLine());
                Console.WriteLine("Первое число до смены " + firstVariable);
                Console.WriteLine("Второе число до смены " + secondVariable);
                ChangesOfVariable(ref firstVariable, ref secondVariable);
                Console.WriteLine("Первое число после смены " + firstVariable);
                Console.WriteLine("Второе число после смены " + secondVariable);

        }

        static void ChangesOfVariable(ref int firstVariable, ref int secondVariable)
        {
            (firstVariable, secondVariable) = (secondVariable, firstVariable);
        }

    }
}
