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
            Translation translation = new Translation();

            // Task to do.
            // We need to load the file to Dictionary
            translation.LoadFileToDictionary(userInpu);



            string userInput = StringProcessing.GetValidInput();
            

            
            bool isWordInDictionary = Translation.VerifyWordInDictionary(userInput);

            // Add a word to the dictionary
            translation.AddWordToDictionary(userInput, isWordInDictionary);

            // Print the word we just added to the dictionay
            translation.PrintDictionary();

            // Add the new word to the dictionary if it is not alreday in the dictionary.
            translation.SaveDictionaryToFile();

            // Print the updated dictionary file. It should contain the new word that we just added.
            Console.WriteLine("The dictionay contains the following words:");
            translation.PrintFileToScreen();

        }
    }
}
