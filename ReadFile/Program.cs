using ReadingFile;
using System;
using System.IO;
using System.Linq;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // I have change this line
            //StreamReader file = new StreamReader(@"File1_temporary.txt");
            // With this line:
            string filename = @"File1_temporary.txt";
            // take look in FileHelper.cs

            // Call the file FileHelper.cs that content the method ReadData
            FileHelper.ReadData(filename);


            //I have problem here in call the method
            //I have use string inputValues as parameter ,  take look in ArrayHelper.cs
            // give me some hints to do it :)
            ArrayHelper.DisplayData();
            
        }
    }
}