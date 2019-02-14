using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp15
{
    class Program
    {
        static int[] arrMaker(string[] arr)
        {
            int cnt = -1;                               // начальное кол-во равно -1 
            int[] array = new int[arr.Length * 2];      //создаем массив который в 2 раза больше изначального 
            for (int i = 0; i < arr.Length; i++)        // пробегаемся с 0 до длины первого массива
            {
                cnt++;
                array[cnt] = int.Parse(arr[i]);         // переводим массив array[0]=1
                cnt++;
                array[cnt] = int.Parse(arr[i]);         // array[1]= 1
            }
            return array;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();              // читаем первую строку 
            int n = int.Parse(s);                       // переводим string на int
            string k = Console.ReadLine();              // читаем вторую строку
            string[] arr = k.Split();                   // создадим массив и уберем все пробелы 
            int[] array = arrMaker(arr);                // создаем массив и кидаем старый массив в метод 
            for (int i = 0; i < array.Length; i++)      //пробегаемся от 0 до длины нового массива 
            {
                Console.Write(array[i]);                //выводим значения нового массив
                Console.Write(' ');                     // ставим пробелы между числами 
            }
        }
    }
}