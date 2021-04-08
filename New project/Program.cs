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
            //1 read numbers from file
            //2 write numbers to file2 
            //3 print numbers In reverse number
            // 20,25,0,12,3,5,1
            //4 print max and min number
            // max:25 , min:0
            //5 print numbers in order
            // 0,1,3,5,12,20,25
            FileRead.Read();
           FileWrite.Write();
            MaxAndMin.MxMn();
            //ReverseNum.RevNum();
            //NumbersInOrder.NIO();

            Console.ReadLine();
        }
        
        
      

    }
}
