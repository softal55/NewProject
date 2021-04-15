using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fileContents = File.ReadAllText(@"File1_temporary.txt");
            string line = '\r'.ToString() + '\n'.ToString();
            fileContents = fileContents.Replace(line, '\n'.ToString());
            string[] array = fileContents.Split(new char[] { '\n' });
            int[] intArray = new int[array.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                int.TryParse(array[i], out intArray[i]);
            }
            foreach (int i in intArray)
            Console.WriteLine(i);

           Console.Read();

        }
    }
}