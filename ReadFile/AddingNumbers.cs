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
            //int sumOfNumber = myData.Count();
            //for (int i = 0; i < sumOfNumber; i++)
            //{
            //    sum += myData[i];
                
            //}
            //return myData;
        }

        public static int AddOne(int x)
        {
           x+= 0;
            return x+1;
        }
        public static int Add2Numbers(int a, int b)
        {
            _ = a + b;
            return a + b;
        }
        public static int[] ConvertToArray(int y, int z)
        {
            // declare an array of integer
            int[] smallArray = new int[2];
            int numberOfArray = smallArray.Count();
            Console.WriteLine("Task 3:");
            for (int i = 0; i < numberOfArray; i++)
            {
                Console.WriteLine(y);
                Console.WriteLine(z);

            }
            
            //return an array of integers
            return smallArray;
        }
    }
}
