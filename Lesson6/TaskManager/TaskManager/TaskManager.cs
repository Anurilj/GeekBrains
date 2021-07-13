using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskManager
{
    class TaskManager
    {
        static void Main(string[] args)
        {
            Console.Write("Cписок текущих процессов: ");

            Process[] processes = Process.GetProcesses();
            
            foreach (Process item in processes)
            {
                Console.WriteLine($"{item.Id} {item.ProcessName}");
            }

            Console.WriteLine("Для завершения процесса введите его айди или название:");
            string input = Console.ReadLine();

            foreach (Process item in processes)
            {
                if(input == item.ProcessName || Int32.Parse(input) == item.Id )
                {
                    item.Kill();
                    Console.WriteLine("Process terminated");
                } 
            }
        }
    }
}
