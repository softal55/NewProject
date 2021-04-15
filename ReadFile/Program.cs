using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note 1: Change your code to use ReadLine, similar to this link.
            // In you case, you read line by line, then:
            // 1. Write the line you read to the screen.
            // 2. Add the line to the array.
            // push back when done.
            // 
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time
            // 
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