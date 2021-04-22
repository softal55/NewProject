using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadingFile
{
    class FileWrite
    {
        public static void Write()
        { 
            StreamWriter sw = new StreamWriter(@"WriteToFile.txt");
            string s = "1 3 5 12 0 25 20";
            sw.WriteLine(s);
            sw.Close();
        }
    }
}
