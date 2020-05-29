// Ветвь master
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvirontmentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "пример для работы с git";
            Console.WriteLine("Это конец света");

            Console.WriteLine("Привет, мир!");
            Console.WriteLine($"Компьютер: {Environment.MachineName}, версия ОС: {Environment.OSVersion}");

			// Ветвь master
			int t = 5;
			
            Console.WriteLine($"{(new DriveInfo("c:").TotalFreeSpace) / 1024 / 1024:n0} МБайт");
            Console.Write("\n\n\t");
        } // Main
    }
}
