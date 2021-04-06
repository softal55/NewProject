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
             Read();
            Write();
            Console.ReadLine();
        }
        const string Filename = "File1.txt";
        //When i run he tell me file not found
       static void Read()
       {
           StreamReader sr = new StreamReader(Filename);
           string data = sr.ReadLine();

            
            Console.WriteLine(data);
            sr.Close();
        }
        // when i run this he don't put the number in File2
        const string filename = "File2.txt";
        static void Write()
        {
            StreamWriter sw = new StreamWriter(filename);
            string s = "1 3 5 12 0 25 20  ";
            Console.WriteLine(s);
            sw.Close();
        }
      

    }
}
