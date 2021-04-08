using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace New_project
{
    class FileWrite
    {
        const string filename = "File2.txt";
         public static void Write()
         {
            
            StreamWriter sw = new StreamWriter(filename);
                string s = "1 3 5 12 0 25 20";
                sw.WriteLine(s);
                sw.Close();
            
         }
    }
}
