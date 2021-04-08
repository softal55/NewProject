using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace New_project
{
    class MaxAndMin
    {
        const string Filename = "File1.txt";
        public static void MxMn()
        {
            Console.WriteLine("Get the Max and Min values from The text file");
            using (StreamReader read = new StreamReader(Filename))
            {
                List<int> numbers = new List<int>();

                while (true)
                {
                    string FindMax = read.ReadLine();
                    if (FindMax == null)
                    {
                        break;
                    }
                    string FindMin = read.ReadLine();
                    if (FindMin == null)
                    {
                        break;
                    }

                    int test;
                    if (Int32.TryParse(FindMax, out test))
                    {
                        numbers.Add(test);
                    }
                    
                    if (Int32.TryParse(FindMin, out test))
                    {
                        numbers.Add(test);
                    }

                }

                Console.WriteLine("the max number is {0}", numbers.Max());
                Console.WriteLine("the min number is {0}", numbers.Min());
            }


        }
    }
}    





    


    

