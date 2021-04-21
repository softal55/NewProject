using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadingFile
{
    class FileHelper
    {
        

        public static int[] ReadData(string filename)
        {
           //I have return the array
           // But there are the conflicts of not all the code return value
           // I have try to return it in the while loop , the problem stay
            if (File.Exists(filename))
            {
                StreamReader file = null;

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
                return inputValues;
            }
            
        }
    }
}
