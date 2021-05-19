using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackData
{
    class ReadingFile
    {
        public static string Read(string filename ,Stack<string> mystack)
        {
            if (File.Exists(filename))
            {
                StreamReader file = new(filename);
                string line = file.ReadLine();
                while (line != null)
                {
                    mystack.Push(line);
                    line = file.ReadLine();
                
                }
                file.Close();
                return line;
            }
            return null;
        }
    }
}
