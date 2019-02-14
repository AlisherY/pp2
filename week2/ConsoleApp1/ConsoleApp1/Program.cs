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
        static bool polindrome(string s)
        {
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HP\Desktop\text.txt");
            string s = sr.ReadToEnd();

            if (polindrome(s))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
