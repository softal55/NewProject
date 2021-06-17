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
        //private static bool translatedWord;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'English-French' dictionary!\n");

            Translation translation = new Translation();
            while (true)
            {
                Console.WriteLine("Would you like to update the dictionary or use it?");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {

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
                    break;
                }
                if (i == 2)
                {

                    // Hint 1
                    // First, we load the words from the file to the dictionary. 
                    translation.LoadFileToDictionary();
                    // Now the 'Translation' class knows about the dictionary, but this 'Main' program does not know about it yet.

                    // Hint 2.
                    // To use the dictionary in this 'Main' program, we need to ask the 'Translation' class to give us the
                    // values in the dictionary
                    // So, we will declare a new varibale in this 'Main' program to hold
                    // the values of the dictionary that the 'Translation' class knows about.
                    // And, remember, this is just a declaration. We can give this dictionary any name.
                    // I gave it the name 'englishDictionary', and right now, it is empty.
                    Dictionary<string, string> englishDictionary = new Dictionary<string, string>();

                    // Hint 3
                    // Let us ask the 'Translation' class to give us the values of the dictionary, and we will put them in our
                    // dictionary 'englishDictionary'
                    // Your task is to complete the following method :)
                    englishDictionary = translation.GetDictionary();


                    // Get the word that the user enters for translation!
                    string userInput = StringProcessing.GetValidInput();
                    //  Console.WriteLine(translatedWord);
                    // Console.WriteLine(englishDictionary);

                    //// Hint 4
                    //// You do not need this section. This loop just prints the words that the dictionary holds. Correct?
                    ///// delete it!

                }
            }
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


