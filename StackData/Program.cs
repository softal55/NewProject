using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace StackData
{
    class Program
    {
        static void Main(string[] args)
        {
            // if something is not good
            // give me some hints and i will fix it :)
            string filename = @"StackDataFile.txt";
            Stack<string> mystack = new();
            ReadingFile.Read(filename, mystack);
            foreach (string line in mystack)
            { 
                Console.WriteLine(line);
            }
            DisplayStack.Display(mystack);
        }
    }
}
