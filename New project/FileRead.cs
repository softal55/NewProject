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

        public static void Read()
        {
            Console.WriteLine("Read from text file and ignore \"//\" :");

            // Note 4: move this line to the main program.
            string filename = @"File1_temporary.txt";
            string line;
            string fileContent = "";

            if (File.Exists(filename))
            {
                StreamReader file = null;
                try
                {
                    file = new StreamReader(filename);
                    while ((line = file.ReadLine()) != null)
                    {
                        if (!line.StartsWith("//"))
                        {
                            Console.WriteLine(line);
                            fileContent += line;
                        }
                    }
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

