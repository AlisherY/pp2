using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static bool polindrome(string s)                                    // создаем bool для проверки полиндромности
        {   
            for (int i = 0; i < s.Length/2; i++)                            // создаем форик , где пробегамеся до половины нашего массива(обычная проверка массива на полиндромность)
            {
                if (s[i] != s[s.Length - i - 1]) return false;              // если первая половина массива не равна второй половине то это не полиндром
            }
            return true;                                                    // во всех остальных случая все норм
        }
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HP\Desktop\text.txt");      //вводим наш массив в текстовом файле при этом указываем туда доступ через класс StreamReader
            string s = sr.ReadToEnd();                                          // читаем всю строку в нашем текстовом файле
            if (polindrome(s))                                                  //если в нашей строке выполняется условие для полиндромности то  пишем "Да"
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");                                        // если не выполняется то "Нет"        
        }
    }
}
