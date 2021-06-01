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
               
            


            // Task 3
            // 2. If the user enters a word that does not exist in the dictionary, the program displays a message saying:
            //   This word does not exist in the dictionary.
            //    Would you like to add it to the dictionary (Y or N)?
            //    
            
            //    2.a)
            //    If the user enters 'Y', the system enters the message:
            //    Please enter an English word and its translation, separated by ':'
            //    For example: 'Sky:Ciel'
            //   
            //    Once the word is added to the file, the system displays:
            //    The word 'Sky' has been added to the dictionary
            //    
            //    The system continues normally with the message
            //    Please enter an English word:
            //
            //    2.b)
            //    If the user enters, 'N', then the word is not added to the dictionary.
            //    The system displays:
            //    You have chosen not to add the 'Ciel' to the dictionay.
            //    Then, the system continues normally with the message
            //    Please enter an English word:
            // 
            // Let me know if you have any questions about what needs to be done.
            // (in software, we call these requirements)
            // 
            // Feel free to make any changes to get the program to work.

            //  Translation.GetDictionaryData();

        }
    }
}
