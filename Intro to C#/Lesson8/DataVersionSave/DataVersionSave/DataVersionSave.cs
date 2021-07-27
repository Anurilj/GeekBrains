using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVersionSave
{
    class DataVersionSave
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Properties.Settings.Default.Greeting}");

            if (string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                Console.WriteLine("Введите имя:");
                Properties.Settings.Default.Name = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.Age))
            {
                Console.WriteLine("Введите возраст:");
                Properties.Settings.Default.Age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.Job))
            {
                Console.WriteLine("Введите род деятельности:");
                Properties.Settings.Default.Job = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            Console.WriteLine($"Добрый день, {Properties.Settings.Default.Name}, возраст: {Properties.Settings.Default.Age}, род деятельности: {Properties.Settings.Default.Job}");
        }
    }
}
