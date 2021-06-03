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

            // Task 1.
            //      1.1
            //      If the user enters a word with 2 characters or less, the system displays
            //      Sorry, this word is too short. Please enter a word with 3 characters or more.
            //
            //     1.2.
            //     If the user enters non-alphabetic characters (like 1, 2, $, %, *, and so on), the system displays:
            //     Please enter alphabetic characters only, with 3 characters or more.
           
            string userInput = StringProcessing.GetValidInput();
           
            // Console.WriteLine($"The word '{userInput}' is acceptable");


            // Task 2.
            // Cpmplete this method.
            bool isWordInDictionary = Translation.VerifyWordInDictionary(userInput);

            // Complete the following method.
            // The method adds the word to dictionary if it does not exist.

            // Task 3
            Translation translation = new Translation();
            translation.AddWordToDictionary(userInput, isWordInDictionary);
            translation.PrintDictionary();
            // See this page for samples to write a dictionary tpo a file.
            translation.SaveDictionaryToFile();
            // Here is  the description for this method.
            //   3.a)
            //   If the word that does not exist in the dictionary, the program displays a message saying:
            //   This word does not exist in the dictionary.
            //   (Assume the user entered 'Sky')
            //    Would you like to add it to the dictionary (Y or N)?
            //    
            
            //    3.b)
            //    If the user enters 'Y', the system enters the message:
            //    Please enter a french word for this English word:
            //    For example: Ciel
            //   
            //    Once the word is added to the dictionry, the system displays:
            //    The word 'Sky' has been added to the dictionary
            //    
            //    The system continues normally with the message
            //    Please enter an English word:
            //
            //    3.c)
            //    If the user enters, 'N', then the word is not added to the dictionary.
            //    The system displays:
            //    You have chosen not to add the word 'Ciel' to the dictionay.
            //    Then, the system continues normally with the message
            //    Please enter an English word:
            // 
            // Let me know if you have any questions about what needs to be done.
            // (in software, we call these requirements)
            // 
            // Feel free to make any changes to get the program to make it work.

            //  Translation.GetDictionaryData();

        }
    }
}
