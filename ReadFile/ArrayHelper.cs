using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadingFile
{
    class ArrayHelper
    {
        public static void DisplayData( string inputValues)
        {
        
          int numberOfItemsInArray = inputValues.Count();
          Console.WriteLine("The array has the following elements");
          for (int i = 0; i < numberOfItemsInArray; i++)
          {
                Console.WriteLine(inputValues[i]);
          }
        }
    }
}
