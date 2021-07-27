using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerealization
{
    class BinarySerealization
    {
        static void Main(string[] args)
        {

            Console.Write("Введите набор чисел от 0 до 255, разделяя их пробелом: ");
            string outputDatata = Console.ReadLine();

            for (int i = 0; i < outputDatata.Length; i++)
            {
                if (!Char.IsWhiteSpace(outputDatata[i]) && !Char.IsNumber(outputDatata[i]))
                {
                    Console.WriteLine("Вы ввели неверные данные!");
                    return;
                }
            }

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), outputDatata);
        }
    }
}
