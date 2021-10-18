using System;

namespace ConsoleApp5
{
    class OneMain
    {
        static void Main(string[] args)
        {
            DK1 qq = new DK1();
            DK1.PrintUsername();
            DK2 ww = new DK2();
            DK2.metod();
            DK3 ee = new DK3();
            DK3.lalala();
        }
    }
    class Employee
    {
        public static void PrintUsername()
        {
            Console.Write("Введите своё имя:");
            string rr = Console.ReadLine();
            Console.WriteLine($"Имя пользователя:{rr}");
            Console.ReadKey();
        }
        public static void metod()
        {
            Console.WriteLine("Хоп хей лалалей");
        }
        public static void lalala()
        {
            Console.WriteLine("Танцуют все");
        }

    }
    class DK1 : Employee
    {


    }
    class DK2 : Employee
    {


    }
    class DK3 : Employee
    {


    }
}