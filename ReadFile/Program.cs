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
 
            // Declare a counter that will be used to count the number of integers we read.
            int counter = 0;

            // Declare an array that can hold a maximum of 7 integers
            int[] inputValues = new int[7];

            // Open the file for reading, using a StreamReader.
            StreamReader file = new StreamReader(@"File1_temporary.txt");

            // Read the first line in the file
            var number = file.ReadLine();
          
            // Check if the number is null.
            while (number != null) 
            {
                // Now, we know that the number is not null. 
                // So, we will add this number to the array.
                inputValues[counter] = int.Parse(number);

                // Now, we increase the counter by 1, because we read one number
                counter++;
                
                // The above line is the same as 
                // copunter = counter + 1; 

                // Now, let us read the next line from the "Stream" called file and put it in the variable called "number"
                number = file.ReadLine();
            }

            // When all the number are read, we skip the while loop to get here.
            // We have no more number to read, so we close the stream called "file"
            file.Close();

            // Now, let us check how many variable we have in the array.
            // The array has a method called "Count" that we can use.
            int numberOfItemsInArray = inputValues.Count();
            
            // Now we loop through each element in the screen and display it.
           Console.WriteLine("The array has the following elements");
            //the mistake in i = 1 , it's i = 0
            for (int i = 0; i < numberOfItemsInArray; i++)  
            {
                
                Console.WriteLine(inputValues[i]);
            }
        }
    }
}