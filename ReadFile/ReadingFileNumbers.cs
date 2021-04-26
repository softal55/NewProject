using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadingFile
{
    class ReadingFileNumbers
    {
        

        public static int[] ReadData(string filename)
        {
            Console.WriteLine("The program will the file now. Hit <Enter> to continue");
            Console.ReadKey();
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);

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
                //Console.WriteLine("The program completed reading all the numbers");
                //Console.WriteLine("and stored them in an array.");
                //Console.WriteLine("Hit <Enter> to continue");

                Console.ReadKey();

                return inputValues;
            }
            // If the file does not exist, we skip the "if" statement. There will be no data in the array.
            // So, we return null.
            return null;
        }
    }
}
