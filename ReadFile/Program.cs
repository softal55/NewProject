using System;
using System.IO;
using System.Linq;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open the file for reading, using a StreamReader.
            StreamReader file = new StreamReader(@"File1_temporary.txt");

            // replace lines 17 to 26 with a new method called ReadData in file called FileHelper.cs
            // You need parameters for the the method.

            int counter = 0;
            int[] inputValues = new int[7];
            var number = file.ReadLine();
            while (number != null)
            {
                inputValues[counter] = int.Parse(number);
                counter++;
                number = file.ReadLine();
            }
            file.Close();

            // Replace lines 31 to 36 with a new method called DisplayData in a file called ArrayHelper.cs
            // You need parameters for the the method.

            int numberOfItemsInArray = inputValues.Count();
            Console.WriteLine("The array has the following elements");
            for (int i = 0; i < numberOfItemsInArray; i++)
            {
                Console.WriteLine(inputValues[i]);
            }
        }
    }
}