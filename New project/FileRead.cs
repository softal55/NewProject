using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace New_project
{
    class FileRead
    {
        public static void Read()
        {
            Console.WriteLine("Read from text file and ignore \"//\" :");
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

