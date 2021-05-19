using System;
using System.Collections.Generic;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"TextFile.txt";

            // Task 1
            // Add a static class to this project called "Word" in a file called Words.cs

            // Task 2
            // Add a method called ReadFile to the class Word.
            // The method takes a string parameter and returns a list of strings.
            List<string> wordsInFile = Word.ReadFile(filename);

            // Task 3
            // Add a method to the class Word called GetNumberOfWords.
            // The method takes a list of words and returns the number of words in the list
            int numberOfWords = Word.GetNumberOfWords(wordsInFile);
            for (int i = 0; i < numberOfWords; i++)
            {
              Console.WriteLine(wordsInFile[i]);
            }
                Console.WriteLine("End of tasks!");
        }
    }
}
