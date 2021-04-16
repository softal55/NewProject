using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;

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
           
            int counter = 0;
            //string line;
            


             
            StreamReader file = new StreamReader(@"File1_temporary.txt");

            
            int[] inputValues = new int[7];

            // I am replacing this line with other lines to make it easier to see
            // the execution logic.
            // while ((line = file.ReadLine()) != null)
            var number = file.ReadLine(); // read the first line in the file
            while (number != null) 
            {
                
                inputValues[counter] = int.Parse(number);
                Console.WriteLine(number);
                counter++; 
                number = file.ReadLine(); // read the next line in the file
            }

            file.Close();
            // We do not need the next 2 lines.
            //Console.WriteLine($"File has {counter} lines" , inputValues);
            //Console.ReadLine();

            

            
            // At this point. we have an array that holds 7 numbers.
            // Note 1: Write code that writes the numbers in the array to the screen
            // push back wghen done!

        }
    }
}