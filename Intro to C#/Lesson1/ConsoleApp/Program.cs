using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("Введите имя: ");
            name += Console.ReadLine();
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Привет, {name}, сегодня {dateTime}");
            Console.ReadKey();
        }
    }
}