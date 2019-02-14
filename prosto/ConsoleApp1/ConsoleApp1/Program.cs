using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("How old are you?");
                num = Convert.ToDouble(Console.ReadLine());
            if (num > 23.15d)
                Console.WriteLine("You are older than 23.15");
            else
                Console.WriteLine("You are Good");
            
            Console.ReadKey();

            
            
        }
    }
}
