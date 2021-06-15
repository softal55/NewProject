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
            Console.WriteLine("Welcome to the 'English-French' dictionary!\n");

            Translation translation = new Translation();

            // Load the file to Dictionary
            translation.LoadFileToDictionary();

            bool updateDictionary = true;
            string answer;
            do
            {
                ManageDictionary(translation);
                Console.WriteLine("Would you like to enter another word?");
                answer = Console.ReadLine().ToUpper();

                if (answer == "N")
                {
                    Console.WriteLine("Thank you for using the dictionary , you can close the app with any key");
                    updateDictionary = false;
                    Console.ReadKey();
                }

            } while (updateDictionary);
        }

        private static void ManageDictionary(Translation translation)
        {
            //Console.WriteLine("Welcome to the 'English-French' dictionary!\n");
            //Translation translation = new Translation();

            //// Load the file to Dictionary
            //translation.LoadFileToDictionary();

            string userInput = StringProcessing.GetValidInput();

            bool isWordInDictionary = Translation.VerifyWordInDictionary(userInput);

            if (isWordInDictionary)
            {
                Console.WriteLine($"The word '{userInput}' was not added to the dictionary because it already exist in the dictionary.\n");
            }

            // NOTE: the '!' means 'NOT'.
            // So, this is the same as saying (if not isWordInDictionary) of (if isWordInDictionary == false)
            if (!isWordInDictionary)
            {
                Console.WriteLine($"The word '{userInput}' does not exist in the dictionary.");
                Console.WriteLine("Would you like to add it to the dictionary (Y or N)?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    // Add a word to the dictionary
                    translation.NewMethod_AddWordToDictionary(userInput);
                }

                if (answer == "N")
                {
                    Console.WriteLine($"You have chosen not to add the word '{userInput}' to the dictionay.");
                    //Console.WriteLine("Would you like to enter another word?");
                }
            }

            translation.SaveDictionaryToFile();
            translation.PrintDictionary();

            Console.ReadKey();
        }
    }
}
