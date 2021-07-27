using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class ChequeVars
    {
        static void Main(string[] args)
        {
            // in real life i would just put var everywhere instead of strict 
            string company = "           ООО Отрава";
            string adress = "   131311 г. Москва, ул. Лубянка, д. 1";
            string website = "           www.hateyou.com";
            string doubleDash = "========================================";
            string order = " Заказ № 431";
            string name = "             * КАССОВЫЙ ЧЕК * \n               * ПРИХОД *";
            string singleDash = "----------------------------------------";
            string VAT = "      НДС 20%     ";
            float VATval = 1.20f;
            string product1 = " Беляш с к.";
            float product1_price = 200.00f * VATval;
            string product2 = " Нектар г. ";
            float product2_price = 50.00f * VATval;
            string TotalStr = "                      ИТОГО : ";
            float total = product1_price + product2_price;
            string VATinc = "     В т. ч. налоги НДС 20% : ";
            double vatExc = Math.Round( (double) total - ( total / VATval ), 2);
            string cachier = "  КАССИР: Груздь Д. А.";
            var date = DateTime.Now;
            string chequeNum = "  ДОК. № 1243131412";

            Console.WriteLine( $"{ company } \n{adress} \n{website} \n{doubleDash} \n{order} \n{name} \n{singleDash}");
            Console.WriteLine( $"\n{product1} {VAT} {product1_price} \n{singleDash}" );
            Console.WriteLine( $"\n{product2} {VAT} {product2_price} \n{singleDash}" );
            Console.WriteLine( $"\n{TotalStr} {total} \n{VATinc} {vatExc} \n{doubleDash}");
            Console.WriteLine($"\n{cachier} \n  {date.ToString("dd:mm:yyyy hh:mm:ss")} \n{chequeNum}");

            Console.ReadKey();
        }
    }
}
