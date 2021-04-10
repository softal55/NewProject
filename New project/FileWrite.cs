using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace New_project
{
    class FileWrite
    {
        // Note 5:
        // Move this line to the main program
        const string filename = "File2.txt";
         
        // Note 6:
        // Change the Write merhod so that it takes the filename as a parameter of type string.
        public static void Write()
         {
            
            StreamWriter sw = new StreamWriter(filename);
                string s = "1 3 5 12 0 25 20";
                sw.WriteLine(s);
                sw.Close();
            
         }
    }
}
