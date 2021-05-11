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
        public static int[] read(string filename ,Stack<string> mystack)
        {
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                

                string line = file.ReadLine();
                while (line != null)
                {
                    mystack.Push(line);
                    line = file.ReadLine();
                }
                mystack.Pop();
                file.Close();
                Console.ReadKey();   
            }
            return null;
        }
    }
}
