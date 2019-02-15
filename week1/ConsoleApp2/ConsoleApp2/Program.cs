using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        
        private string name;
        private string id;
        private int yearofstudy;
        
        public Student (string name, string id)
        {
            this.name = name;                       //ключевое слово this ссылается на текущий эекземпляр класса ( так как имеется одинаковые имена в этом коде )
            this.id = id;
        }
        public string getName()             //получить Имя студента
        {
            return this.name;
        }
        public string getId()               // получить ID студента
        {
            return this.id;
        }
       public int Increment()               // то же самое как cnt но увеличиваетс только на 1
        {
            return ++yearofstudy;           // возвращает нам год обучения 
        }

       
    }
}
