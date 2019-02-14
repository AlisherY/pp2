using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool isPrime(int n)  //функция для нахождения простых чисел
        {
            if (n == 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();         //читаем первую строку 
            int n = int.Parse(s);                  //конвертируем переменную string в int
            
            string k = Console.ReadLine();         //читаем вторую строку
            string[] arr = k.Split(' ');           //записываем в новый массив удалив пробелы между числами
            int cnt = 0;                           //начальное кол-во простых чисел                   
            for (int i = 0; i < arr.Length; i++)   //создаем форик 
            {
                if (isPrime(int.Parse(arr[i])))    //проверяем числа на прайм, если так, то  cnt+1
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);                //вывод кол-во прайм чисел
            for (int i = 0; i < arr.Length; i++)   // создаем форик для прайм чисел 
            {
                int num = int.Parse(arr[i]);       // новая переменная равно 
                if (isPrime(num))                  // если переменная num является числом прайм,то
                {
                    Console.Write(num);            // выводим все прайм числа 
                    Console.Write(' ');
                }
            }




        }
    }
}
