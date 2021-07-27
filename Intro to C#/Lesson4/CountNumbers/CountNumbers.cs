using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers {
    class CountNumbers {

        static void Main(string[] args) {
            Console.WriteLine("Введите числа, разделяя их пробелом:");
            string input = Console.ReadLine();
            string numbers = "";
            int value = 0;
            for (int i = 0; i < input.Length; i++) {

                if ( !Char.IsWhiteSpace(input[i]) && !Char.IsNumber(input[i])) {
                    Console.WriteLine("Вы ввели неверные данные!");
                    return;
                }

                if( Char.IsNumber(input[i]) && i < input.Length -1 ) {
                    numbers += input[i];
                } else if( Char.IsNumber(input[i]) && i == input.Length - 1 ) {
                    numbers += input[i];
                    int val = Convert.ToInt32(numbers);
                    value += val;
                } else {
                    int val = Convert.ToInt32(numbers);
                    value += val;
                    numbers = "";
                }            
            }
            Console.WriteLine($"Сумма чисел: {value}");
            Console.ReadKey();
        }
    }
}
