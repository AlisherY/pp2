using System;                                                                                 
using System.Collections.Generic;                                                            
using System.Linq;                                                                          
using System.Text;                                                                         
using System.Threading.Tasks;                                                           
using System.IO;                                                                        
                                                                                        
                                                                                        
namespace example                                                                   
{                                                                                  
    class Program
    {                                                                              
        public static void Main(String[] args)                                    
        {                                                                        
            string fileName = "test.txt";                                   //Visual Studio сам создаст файл            
            string xyz = @"C:\Users\HP\Desktop\" + fileName;               //создаем test.txt в десктопе      
            string xyz1 = @"C:\Users\HP\Desktop\forpp2\" + fileName;       //создаем test.txt в папке davai     
            StreamWriter sw = new StreamWriter(xyz);                       //записываем новую переменную sw в xyz
            sw.Write(123456789);                                            //записываем в sw "12345"                
            sw.Close();                                                                                             
            File.Copy(xyz, xyz1);                                         //копируем xyz в xyz1                      
            File.Delete(xyz);                                              //удаляем xyz                                 

        }
    }
}