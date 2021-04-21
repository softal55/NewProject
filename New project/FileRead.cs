using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace New_project
{
    class FileRead
    {
        // NOTE 3:
        // Change this method as follows:
        // public int [] Read(string fileName)
        // 1. It takes the file name as a paramater of type string
        // 2. It returns an array of integers.
        // The logic of the method is as follows:
        // you declare an array that holds the numbers you read. 
        // Then, everytime you read a number, you add it to the array.
        // Finally, once all the numbers are read, you return the array.
        public int test()
        {
            int x = 5;
            if(x==5)
            {
                x = 5;
                return 5;
            }
            else
            {
                
                return 5;
            }
            //return 5;
        }
        public  int[] Read(string filename)
        {
            // var inputValues = new List<int>();
            int[] inputValues = new int[7];

            

            Console.WriteLine("Read from text file and ignore \"//\" :");

            // Note 4: move this line to the main program.


            //string line = '\r'.ToString() + '\n'.ToString();
            string line;

            



            if (File.Exists(filename))
            {
                
                StreamReader file = null;
                
                try
                {
                    
                    while ((line = file.ReadLine()) != null)
                    {
                        
                        string[] arr = line.Split(',');
                        if (!line.StartsWith("//"))
                        {
                            Console.WriteLine(line);
                            fileContent += line;
                            
                        }
                       
                      
                    }
                    return inputValues;
                }

                finally
                {
                    if (file != null)
                        file.Close();
                    
                }
                
                


            }
        }
        
    }

}

