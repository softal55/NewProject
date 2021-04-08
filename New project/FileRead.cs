using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace New_project
{
    class FileRead
    {
        const string Filename = "File1.txt";
        public static void Read()
        {
            Console.WriteLine("Read numbers from text file");
            StreamReader sr = new StreamReader(Filename);
            string data = sr.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            sr.Close();
        }
       
    }
}
