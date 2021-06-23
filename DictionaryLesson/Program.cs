using System;
using System.Collections.Generic;
using System.IO;

// Watch these videos on dictiony in C#
// https://www.youtube.com/watch?v=jOLFsT6j9Wg
// 
namespace DictionaryLesson
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'English-French' or 'French-English' dictionary!\n");
            Console.WriteLine("Do you want to use 'English-French' or 'French-English' dictionary (E or F)?");
            string answr = Console.ReadLine().ToUpper();
            
            if(answr == "E")
            {
                EnglishDictionary.englishDictionary();
            }
            if(answr == "F")
            {
                FrenchDictionary.frenchDictionary();
            }
        }
    }
}


