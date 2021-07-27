using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class MonthName
    {
        static void Main(string[] args)
        {
            String[] Months = { "Январь", "Феврать", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.Write("Введите порядковый номер месяца: ");
            if (Int32.TryParse(Console.ReadLine(), out int month)) {
                if (month >= 1 && month <= 12) {
                    var monthName = Months[month-1];
                    Console.WriteLine($"Выбранный месяц: {monthName}");
                } else {
                    Console.Write("Данные не верные!");
                }
            } else {
                Console.Write("Введите числовое значение!");
            }
            Console.ReadKey();
        }
    }
}
