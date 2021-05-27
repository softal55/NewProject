using System;
using System.Collections.Generic;

// Watch these videos on dictiony in C#
// https://www.youtube.com/watch?v=jOLFsT6j9Wg
// 
namespace DictionaryLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Change this project to be used as English => French translator.
            // Feel free to make any changes you want to implement the translator.
            //
            // Here is how it works.
            // The user enters an English word and the system diplays the translation.
            //
            // Here what is looks lik.
            // Please enter an English word: 
            // Suppose the user enters 'House'
            // The system displays the following.
            // The French word for 'House' is 'Maison'

            // I moved this line to the 'Translation'
            // string filename = @"TranslationFile.txt"; 
            // 
           // Dictionary<string, string> translatedWords = 
                Translation.GetDictionaryData();

            // Display the number of objects in the list
          // Console.WriteLine($"The list has {translatedWords.Count} objects");
        }
    }
}
