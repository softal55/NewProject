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
            // int [] myData
            _ = File.ReadAllLines(@"File1_temporary.txt");
            
           int sum = myData.Sum();
            return sum;
        }

        public static int AddOne(int x)
        {
            x = x + 1;
            return x;
        }
        public static int Add2Numbers(int a, int b)
        {
            int c;
            c= a + b;
            return c;
        }
        public static int[] ConvertToArray(int y, int z)
        {
            // declare an array of integer
            int[] smallArray = new int[2];
            smallArray[0] = y;
            smallArray[1] = z;
            return smallArray;
        }

         public static int MaxNumber(int[] myData)
         {
            int max = myData.Max();
            return max;
        }

        public static int MinNumber(int[] myData)
        {
            int min = myData.Min();
            return min;
        }
    }
}
