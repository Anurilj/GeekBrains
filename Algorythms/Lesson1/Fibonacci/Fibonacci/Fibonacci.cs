using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест кода числа Фибоначчи");
            int[] checkArray = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }; //if increase test results dont forget to input more numbers
            Console.WriteLine("Циклический метод:");
            int input = 0;
            while (input < 10)
            {
                input++;
                var output = CalcFibIt(input);
                Console.WriteLine($"ввод: {input}, ожидание: {checkArray[input-1]}, вывод: {output}");
            }
            Console.WriteLine("\nРекурсивный метод:");

            input = 0;
            while (input < 10)
            {
                input++;
                var output = CalcFibRec(input);
                Console.WriteLine($"ввод: {input}, ожидание: {checkArray[input - 1]}, вывод: {output}");
            }
        }

        static int CalcFibIt(int input)
        {
            int m1 = 0;
            int m2 = 1;
            if(input < 1)
            {
                return m1;
            }

            int m;
            for (int i = 1; i < input; i++)
            {
                m = m1;
                m1 = m2;
                m2 = m2 + m;
            }
            return m2;
        }

        static int CalcFibRec(int input)
        {
            if (input <= 1)
            {
                return input;
            }
            else
            {
                return CalcFibRec(input - 1) + CalcFibRec(input - 2);
            }
        }
    }
}
