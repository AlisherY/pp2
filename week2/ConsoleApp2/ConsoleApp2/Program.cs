using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static bool prime(int n)                    // создаем bool для нахождения прайм чисел
        {
            if (n == 1 || n == 0) return false;     //создаем условие для переменной если n = 1 n = 0
            for(int i = 2; i < n; i++)              //создаем форик и пробегамеся от 2 до n
            {   
                if (n % i == 0) return false;       // проверяем есть ли остаток при делении n на i
            }
            return true;                            // если все условия для нахождения прайм чисел выполняются то возвращаем true

        }

         static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HP\Desktop\input.txt");       // получаем доступ к текстовому файлу ,считываем данные из файла с помощью StreamReader
            string s = sr.ReadToEnd();                                                  //     читаем строку в текстовом файле                                                             
            string[] arr = s.Split(' ');                                                // создаем массив и сплитуем пробелами между элементами
            sr.Close();                                                                 //делаем для того чтобы гарантированно закрылась на последней строке
            StreamWriter sw = new StreamWriter(@"C:\Users\HP\Desktop\output.txt");      //новая переменная sw записывается в новый файл
            string res = "";                                                            // создаем переменную и присваиваем к этой переменной некую пустоту
            for (int i = 0; i < arr.Length; i++)                                        // создаем форик и пробегаемся от 0 до длины массива
            {
                int num = int.Parse(arr[i]);                                            
                if (prime(num))                                                         // проверяем число на его прайм 
                {
                    res = res + num + " ";                                              // присваиваем res новые значения
                }

            }
            sw.Write(res);                                                              // выписываем новые значения res
            sw.Close();                                                                 // закрываем sw
        }   
    }
}
