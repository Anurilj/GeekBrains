using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class AverageTemprature
    {
        static void Main(string[] args)
        {
            Console.Write( "Введите минимальную температуру за сутки: " );
            if( Int32.TryParse( Console.ReadLine(), out int tempMin ) ) {
                Console.Write("Введите максимальную температуру за сутки: ");
                if( Int32.TryParse(Console.ReadLine(), out int tempMax) ) {
                    var tempAvg = (tempMin + tempMax) / 2;
                    Console.WriteLine( $"Среднесуточная температура: {tempAvg}" );
                } else {
                    Console.Write( "Введите числовое значение!" );
                }
            } else {
                Console.Write( "Введите числовое значение!" );
            }
            Console.ReadKey();
        }
    }
}