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
            Console.WriteLine("Original lines: " + line);

            char[] splitLine = line.ToCharArray();
            Console.WriteLine("First digit of problem: " + splitLine[0]);

            int holes = 0;
            Console.WriteLine("Original holes: " + holes);

            //Potential problem: line[i] may be an int, while all case '#' are chars, so even when line[i] has a 4, it will not register as '4'     
            int i;
            
                for (i = 0; i >= splitLine.Length; i++)
                {
                    char number = splitLine[i];
                    Console.WriteLine("Testing: should be 1: "+number);
                    switch (splitLine[i])
                    {                        
                        case '4':
                            holes++;
                            break;                     
                        case '6':
                            holes++;
                            break;                        
                        case '8':
                            holes += 2;
                            break;
                        case '9':
                            holes++;
                            break;
                        case '0':
                            holes++;
                            break;
                        default:
                            continue;
                    }                    
                }
                Console.WriteLine("Number of holes in lines " + holes);
            
            





        }
    }
}
