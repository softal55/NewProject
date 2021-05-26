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
            // Task 1:
            // Create a class called "Translation" in a file called "Translation.cs"
            // The class has 2 properties
            // 1. public string Word;
            // 2. public string Meaning;

            // Task 2:
            // Add a method to the Translation class.
            // The method takes a file name and returns a list of object of type 'Translation'
            // Each object contains the word and the meaning from the file.
            string filename = @"TranslationFile.txt";
            Dictionary<string, string> translatedWords = Translation.GetDictionaryData(filename);

            // Display the number of objects in the list
            Console.WriteLine($"The list has {translatedWords.Count} objects");
        }
    }
}
