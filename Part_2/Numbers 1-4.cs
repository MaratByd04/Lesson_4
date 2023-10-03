using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class Numbers
    {
        static bool CalculateFactorial(int n, out long result)
        {
            result = 1;

            try
            {
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        result *= i;
                    }
                }
                return true; // Успешно вычислено
            }
            catch (OverflowException)
            {
                return false; // Произошло переполнение
            }
        }

        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int number); // Здесь можно указать желаемое число для вычисления факториала
            long factorialResult;

            if (CalculateFactorial(number, out factorialResult))
            {
                Console.WriteLine($"Факториал числа {number} равен {factorialResult}");
            }
            else
            {
                Console.WriteLine($"Ошибка: переполнение при вычислении факториала числа {number}");
            }
        }

        
    }
}
