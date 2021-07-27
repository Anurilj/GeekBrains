using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFullName {
    class GetName {

        static void Main(string[] args) {
            string[] nameDatabase = new string[4];
            for (int i = 0; i < nameDatabase.Length; i++) {
                Console.WriteLine($"Запись {i+1} из 4");
                Console.Write("Введите Имя: ");
                string firstName = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string lastName = Console.ReadLine();
                Console.Write("Введите Отчество: ");
                string patronymic = Console.ReadLine();

                string fullName = GetFullName(firstName, lastName, patronymic);
                nameDatabase[i] = fullName;
                Console.WriteLine();
            }

            Console.WriteLine("Общий список:");
            for ( int j = 0; j < nameDatabase.Length; j++) {
                char symbol = j == nameDatabase.Length - 1 ? '.' : ';';

                Console.WriteLine($"{nameDatabase[j]}{symbol}");
            }
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic ) {
            string fullName = firstName + " " + lastName + " " + patronymic;
            return fullName;
        }
    }
}