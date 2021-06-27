using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBook {
    class TelephoneBook {
        static void Main(string[] args) {
            string[,] array = {
                { "Marcus", "MarcusKillan@google.com" },
                { "Ted", "+79262422123" },
                { "Fred", "+79266454768" },
                { "Janny", "JLove@ya.ru" },
                { "Sandy", "Sandy123@yahoo.com" }
            };
            Console.WriteLine("Справочник контактов: \n");
            for (int i = 0; i < array.GetLength(0); i++) {
                Console.WriteLine($"{array[i, 0]}, {array[i, 1]}");
            }
        }
    }
}
