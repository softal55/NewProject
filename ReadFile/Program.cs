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
            int sumOfNumbers = AddingNumbers.Add(myData);

            Console.WriteLine ("Sum = {0}", sumOfNumbers);
            //Console.ReadKey();

            // Task 1:
            int x = 6;
            // This method return x+ 1 
            int addOne = AddingNumbers.AddOne(x);
            Console.WriteLine("X = {0}", x); // 7

            // Task 2
            int a = 6;
            int b = 7;
            // This method return the sum of a+b
            int add2Numbers = AddingNumbers.Add2Numbers(a,b);
            Console.WriteLine("X = {0}", x); //  13

            // Task 3
            int y = 5;
            int z = 22;
            // this method return an array of integers which are y and z.
            int[] smallArray = AddingNumbers.ConvertToArray(y, z);

            // Use a while loop to display the numbers in the array smallArray
            // It should print 5 and 22

        }
    }
}