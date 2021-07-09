using System;
using System.IO;

namespace AddCurrentTime
{
    class AddCurrentTime
    {
        static void Main(string[] args)
        {
            File.AppendAllText("startup.txt", Environment.NewLine);
            File.AppendAllText("startup.txt", DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
