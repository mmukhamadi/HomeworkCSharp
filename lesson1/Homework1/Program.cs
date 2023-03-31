using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine(name + " привет!");
            Console.ReadLine();
        }
    }
}
