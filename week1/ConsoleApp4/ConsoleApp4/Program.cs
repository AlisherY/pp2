using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();      //вводим строку 
            int n = int.Parse(s);               //конвертируем string в int
            for (int i = 0; i < n; i++)         // создаем  двойной массив 
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("[*]");       //выводим наши символы в виде звезд 
                }
                Console.WriteLine();            //консоль для того чтобы перейти на след. строку 
            }




        }


    }
}