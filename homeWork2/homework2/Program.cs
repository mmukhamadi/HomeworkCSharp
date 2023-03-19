using System;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace ConsolApp1
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите размер массива: ");
            int n = ReadInt();
            try
            {
                if (n<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Число должно быть больше нуля!");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент номер {i} массива: ", i + 1);
                array[i] = ReadInt();
            }
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int secondMax = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < max && array[i]> secondMax)
                {
                    secondMax = array[i];
                }
            }
            Console.WriteLine($"Второй наибольший элемент = {secondMax}");


        }
        public static int ReadInt()
        {
            if (Int32.TryParse(Console.ReadLine(), out var value))
            {
                 return value;
            }
            else 
            {
                throw new Exception("Вы ввели не число!"); 
            }
        }
    }

    
}