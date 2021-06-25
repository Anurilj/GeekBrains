using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            if (Int32.TryParse(Console.ReadLine(), out int number)) {
                string result = number % 2 == 0 ? "Ваше число четное" : "Ваше число не четное";
                Console.Write(result);
            } else {
                Console.Write("Введите числовое значение!");
            }
            Console.ReadKey();
        }
    }
}
