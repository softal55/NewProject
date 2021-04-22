using System;
using System.IO;
using System.Linq;
using System.Text;

// Make sure to follow these rules so that you do not get conflicts.
// 1. Pull before making any changes to you code
// 2. Make changes to your code
// 3. Push to Github. Fot the message, use the pattern "Completed NOTE 1", for example when you push changes for NOTE 1

namespace New_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE 1
            // Change the return type of the "Read" method to an array.
            // So the method call becomes 
            // var [] inputValues  = FileRead.Read();
           
           var [] inputValues = FileRead.Read();
           
            
            string filename = @"File1_temporary.txt";
            // NOTE 2: change the Write method as follows
            // FileWrite.Write(inputValues);
           FileWrite.Write(inputValues);
            const string filename = @"File2.txt";

            MaxAndMin.MxMn();
            ReverseNum reverseNum = new ReverseNum();
            reverseNum.RevNum();
            //NumbersInOrder.NIO();

            Console.ReadLine();
        }
        
        
      

    }
}
