using ReadingFile;
using System;
using System.IO;
using System.Linq;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"File1_temporary.txt";

            // Read data from the file and return an array
            int[] myData = ReadingFileNumbers.ReadData(filename);

            // Pass the array to the method "DisplayData" to display the numbers on the screen
            DisplayingArrayNumbers.DisplayData(myData);

            // Here is your next homework:
            // Add a class called "AddingNumbers" to the project. The class has one method called "Add"
            // The "Add" method takes the array, which is "myData", adds all the numbers in the array and returns the sum.
            int sumOfNumbers = AddingNumbers.Sum(myData);
           
             Console.WriteLine ("Sum = ", sumOfNumbers);
        }
    }
}