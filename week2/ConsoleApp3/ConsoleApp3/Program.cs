using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace example
{
    class Program
    {
        static void whitespace(int level)                               //создаем пустоту в самом начале 
        {
            for (int i = 0; i < level * 5; i++)                         // создаем форик для кол-ва пробелов дл внутренних папок и файлов
            {
                Console.Write(' ');
            }
        }
        static void print(string path, int level)                       
        {
            DirectoryInfo d = new DirectoryInfo(path);                  // создаем директорию Д с путем к файлу (path выполняет операцию, содержащие сведерния о пути к файлу
            FileInfo[] fileInfos = d.GetFiles();                        //создаем массив directoryInfos и записываем туда файлы из директории d с путем path (FileInfo нам необходим чтобы выполнить много операций над конкретным файлом 
            DirectoryInfo[] directoryInfos = d.GetDirectories();        //создаем массив directoryInfos и записываем туда файлы из директории d с путем path


            foreach (FileInfo f in fileInfos)                           //для каждого файла новой переменной f в fileInfos
            {
                whitespace(level);                                      //пустота будет равна 0, так как это файл
                Console.WriteLine(f.Name);                              //записываем имя файла
            }
            foreach (DirectoryInfo dinfo in directoryInfos)             //для каждой директории новой переменной dinfo в directoryInfos
            {
                whitespace(level);                                      //первая пустота равна нулю         
                Console.WriteLine(dinfo.Name);                          //записываем в консоль имя дииректории  
                print(dinfo.FullName, level + 1);                       //level+2 чтобы 0 не умножать на 5 чтобы была пустота
            }

        }

        public static void Main(String[] args)                          //в принте записываем путь к файлу и level изначально который должен быть равен 0
        {
            print(@"C:\Users\HP\Desktop\NewFolder", 0);
        }
    }
}