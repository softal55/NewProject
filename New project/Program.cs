using System;
using System.IO;
using System.Linq;
using System.Text;

namespace New_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE 1:
            // Change your program so that it ignores lines that start with "//"
            // See example "File1_temporary.txt"
            // Make sure to follow these rules so that you do not get conflicts.
            // 1. Pull before making any changes to you code
            // 2. Make changes to your code
            // 3. Push to Github. Fot the message, use the pattern "Completed NOTE 1", for example when you push changes for NOTE 1
            //
            // When You complete NOTE 1, I will give you more notes to complete :)
            // 
            FileRead.Read();

           FileWrite.Write();
            MaxAndMin.MxMn();
            //ReverseNum.RevNum();
            //NumbersInOrder.NIO();

            Console.ReadLine();
        }
        
        
      

    }
}
