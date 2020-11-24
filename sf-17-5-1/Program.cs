using System;

namespace sf_17_5_1
{
    class Program
    {
        static ICalculator Calculator { get; set; }
        static void Main(string[] args)
        {
            Calculator = new Calculator();

            while(true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    int numberOne = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    int numberTwo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выполняем операцию сложения...");
                    Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, Calculator.Addition(numberOne, numberTwo));
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("Введите корректное число!");
                }

                catch(Exception ex)
                {
                    Console.WriteLine("Произошла непредвиденная ошибка в приложении. Текст ошибки: {0}", ex.Message);
                }
            }
        }
    }
}
