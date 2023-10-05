using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    internal class Exercises
    {
            
            static int LargerOfTwoNumbers(int firstNumber, int secondNumber) // Метод для упр 5.1.
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

              static void ChangesOfVariable(ref int firstVariable, ref int secondVariable) // Метод для Упр 5.2
              {
                   (firstVariable, secondVariable) = (secondVariable, firstVariable);
              }

        static void Main(string[] args)
        {
                Console.WriteLine("Проверка Упражнения 5.1. Наибольшее из двух целых чисел.\n");


                Console.WriteLine("Введите первое число.");
                int.TryParse(Console.ReadLine(), out int firstNumber);
                Console.WriteLine("Введите второе число.");
                int.TryParse(Console.ReadLine(), out int secondNumber);
                LargerOfTwoNumbers(firstNumber, secondNumber);
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("Упражнение 5.2. Смена двух чисел.\n");


                Console.WriteLine("Введите первое число.");
                int.TryParse(Console.ReadLine(), out var firstVariable);
                Console.WriteLine("Введиет второе число.");
                int.TryParse(Console.ReadLine(), out var secondVariable);
                Console.WriteLine("Первое число до смены " + firstVariable);
                Console.WriteLine("Второе число до смены " + secondVariable);
                ChangesOfVariable(ref firstVariable, ref secondVariable);
                Console.WriteLine("\nПервое число после смены " + firstVariable);
                Console.WriteLine("Второе число после смены " + secondVariable);
                Console.ReadKey();
                Console.Clear();


            Console.WriteLine("Упражнение 5.3. Факториал числа.\n");


            Console.WriteLine("Введите число, факториал которого хотите получить.");
            int.TryParse(Console.ReadLine(), out int numbForFactorial);
            long resultOfFactorial;
            if (Factorial(numbForFactorial, out resultOfFactorial))
            {
                Console.WriteLine("Факториал полученного числа равен = " + resultOfFactorial);
            }
            else
            {
                Console.WriteLine("Ошибка! Переполнение!");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Упражнение 5.4. Рекурсивный факториал.\n");


            Console.WriteLine("Введите число, факториал которого хотите получить.");
            try
            {
                long.TryParse(Console.ReadLine(), out long numbForFact);
                Console.WriteLine(FactorialRekurs(numbForFact));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка! Вы ввели слишком большое число.");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Домашнее задание 5.1. НОД для двух и трех чисел.\n");


            Console.WriteLine("Введите Первое число.");
            int.TryParse(Console.ReadLine(), out int numb1);
            Console.WriteLine("Введите Второе числою.");
            int.TryParse(Console.ReadLine(), out int numb2);
            Console.WriteLine("Введите Третье числою.");
            int.TryParse(Console.ReadLine(), out int numb3);
            int nodFor2numbers = algorithmEuclidean(numb1, numb2);
            int nodFor3numbers = algorithmEuclidean(numb1, numb2, numb3);
            Console.WriteLine("НОД для двух чисел = " + nodFor2numbers);
            Console.WriteLine("НОД для трех чисел = " + nodFor3numbers);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Домашнее задание 5.2. Ряд Фибоначчи.\n");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Предупреждаю! В случае введения номера больше 45 ждать вы будете очень долго, тк метод крайне примитивен.\n");
            Console.ResetColor();
            Console.WriteLine("Введите номер числа из ряда Фибоначчи, которое хотите узнать.\n");

            try
            {
                checked
                {
                    uint.TryParse(Console.ReadLine(), out uint numbOfRowInFibonacchi);
                    Console.WriteLine("F{n} = " + FibonachiNum(numbOfRowInFibonacchi));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели отрицательное число! Пожалуйста, перезапустите программу и попробуйте снова.");
            }
            Console.ReadKey();
            Console.Clear();
        }

       
        static bool Factorial(int numbForFactorial, out long resultOfFactorial) // Метод для задания Упр 5.3
        {
            resultOfFactorial = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= numbForFactorial; i++)
                    {
                        resultOfFactorial *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        static long FactorialRekurs(long numbForFact) // Метод для упражнения 5.4
        {
            checked
            {
                if (numbForFact == 1)
                {
                    return 1;
                }
                else
                {
                    return numbForFact * FactorialRekurs(numbForFact - 1);
                }
            }
        }

        static int algorithmEuclidean(int a, int b) // Метод для НОД двух чисел 
        {
            while (b != 0)
            {
                int forExchange = b;
                b = a % b;
                a = forExchange;
            }
            return a;
        }

        static int algorithmEuclidean(int a, int b, int c) // Метод для НОД трех чисел.
        {
            return algorithmEuclidean(a, algorithmEuclidean(b, c));
        }

        static int FibonachiNum(uint numbOfFibonachiRow) // Метод для дз 5.2.
        {
            if (numbOfFibonachiRow > 0)
            {
                if (numbOfFibonachiRow == 1 || numbOfFibonachiRow == 2)
                {
                    return 1;
                }
                else
                {
                    return FibonachiNum(numbOfFibonachiRow - 1) + FibonachiNum(numbOfFibonachiRow - 2);
                }
            }
            else
            {
                throw new ArgumentException("Число не должно быть отрицательным.");
            }
        }
    }
}
