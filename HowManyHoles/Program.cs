using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyHoles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Numbers.txt");
            //Console.WriteLine(reader.ReadToEnd());
            //Console.WriteLine(reader.ReadLine());

            string line = reader.ReadLine();
            Console.WriteLine(line);
            int holes = 0;

            //Console.WriteLine(line[0]);
            int i;        
                do
                {
                for (i = 0; i < line.Length; i++)
                {
                    Console.WriteLine(line[i]);
                    switch (line[i])
                    {                        
                        case '4':
                            holes += 1;
                            break;                     
                        case '6':
                            holes += 1;
                            break;                        
                        case '8':
                            holes += 2;
                            break;
                        case '9':
                            holes += 1;
                            break;
                        case '0':
                            holes += 1;
                            break;
                        default:
                            break;
                    }
                    
                } 
               Console.WriteLine(holes);
            } while (i == line.Length);

            //string[] lineSplit = line.Split();
            //foreach (string numbers in lineSplit)
            //{
            //    Console.WriteLine(numbers);
            //}

            //string[] test = { "1", "2", "3", "4" };
            //foreach (string number in test)
            //{
            //    Console.WriteLine(number);
            //}





        }
    }
}
