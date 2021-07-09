using System;
using System.IO;


namespace Serealize_text
{
    class Serealize_text
    {
        static void Main(string[] args)
        {
            string filename = "output.txt";
            
            Console.Write("Введите Данные: ");
            string outputDatata = Console.ReadLine();
            File.WriteAllText(filename, outputDatata);
        }
    }
}
