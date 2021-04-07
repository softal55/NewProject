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
            StreamReader sr = new StreamReader(Filename);
            string data = sr.ReadLine();


            Console.WriteLine(data);
            sr.Close();
         }
    }
}
