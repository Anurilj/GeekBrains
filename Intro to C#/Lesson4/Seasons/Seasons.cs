using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons {
    class Seasons {
        enum Season { 
            Winter = 1,
            Spring,
            Summer,
            Autumn    
        }

        static void Main(string[] args) {
            Console.Write("Введите порядковый номер месяца: ");
            if (Int32.TryParse(Console.ReadLine(), out int month)) {
                if (month >= 1 && month <= 12) {
                    Season actualSeason = SeasonName(month);
                    string output = GetRealName(actualSeason);
                    Console.WriteLine($"Вермя года: {output}");
                } else {
                    Console.Write("Ошибка: введите число от 1 до 12");
                }
            } else {
                Console.Write("Ошибка: введите число от 1 до 12");
            }
            Console.ReadKey();
        }

        static Season SeasonName( int num ) {
            int value;
            switch(num) {
                case(12):
                case(1):
                case(2):
                    value = 1;
                    break;
                case(3):
                case(4):
                case(5):
                    value = 2;
                    break;
                case (6):
                case (7):
                case (8):
                    value = 3;
                    break;
                default:
                    value = 4;
                    break;
            }
            Season actualSeason = (Season)value;
            return actualSeason;
        }

        static string GetRealName( Season actualSeason) {
            string output;
            if( actualSeason == Season.Winter ) {
                output = "Зима";
            } else if(actualSeason == Season.Spring) {
                output = "Весна";
            } else if(actualSeason == Season.Summer) {
                output = "Лето";
            } else {
                output = "Осень";
            }
            return output;
           }
    }
}
