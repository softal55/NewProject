using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadingFile
{
    class AddingNumbers
    {
        // I wrrote this ode  :
        public static int  Add(int [] myData)
        {
            _ = File.ReadAllLines(@"File1_temporary.txt");
            //int sum = 0;
            int sum = myData.Sum();
            return sum;
            //int sumOfNumber = myData.Count();
            //for (int i = 0; i < sumOfNumber; i++)
            //{
            //    sum += myData[i];
                
            //}
            //return myData;
        }

        
    }
}
