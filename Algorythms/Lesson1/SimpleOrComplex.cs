using System;

namespace Lesson1_1
{
    class SimpleOrComplex
    {
        static void Main(string[] args)
        {
            TestResults();

            Console.Write("Введите число: ");
            string output = Simple_or_complex(Console.ReadLine());
            Console.WriteLine($"{output}");
        }

        static void TestResults()
        {
            string output_1 = Simple_or_complex("5");
            string output_2 = Simple_or_complex("454");
            string output_3 = Simple_or_complex("9");
            string output_4 = Simple_or_complex("-1");
            string output_5 = Simple_or_complex("kjhfdsew");

            Console.WriteLine($"На вход [5], ожидаем [Число простое], вывод: {output_1}");
            Console.WriteLine($"На вход [454], ожидаем [Число не простое], вывод: {output_2}");
            Console.WriteLine($"На вход [9], ожидаем [Число не простое], вывод: {output_3}");
            Console.WriteLine($"На вход [-1], ожидаем [Ошибка], вывод: {output_4}");
            Console.WriteLine($"На вход [kjhfdsew], ожидаем [Ошибка], вывод: {output_5}");
            Console.WriteLine();
        }

        static string Simple_or_complex( string input )
        {
            if (Int32.TryParse( input, out int n))
            {
                if (n <= 0)
                {
                    return "Число должно быть больше нуля!";
                }
                
                int d = 0;
                int i = 2;
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        d++;
                    }
                    i++;
                }

                if (d == 0)
                {
                    return "Число простое";
                }
                else
                {
                    return "Число не простое";
                }
            }
            else
            {
               return "Вы ввели не число!";
            }
        }
    }
}