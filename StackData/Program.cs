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
