using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadingFile
{
    class FileHelper
    {
        public static void ReadData(string filename)
        {

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
            }
            
        }
    }
}
