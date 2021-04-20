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

            // replace lines 18 to 27 with a new method called ReadData in file called FileHelper.cs
            // the method declaration is like this:
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

            // replace lines 33 to 38 with a new method called DisplayData in file called ArrayHelper.cs
            // the method declaration is like this:
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