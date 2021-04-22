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
            string filename = @"File1_temporary.txt";
            
            int [] myData = FileHelper.ReadData(filename);            
           ArrayHelper.DisplayData(myData);
           FileWrite.Write();

        }
    }
}