using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLesson
{
    class EnglishManage
    {
        public static void ManageEnglishDictionary(Translation translation)
        {

            string userInput = EnterEnglishWord.enterEnglishWord();

            bool isWordInDictionary = Translation.VerifyWordInDictionary(userInput);

            if (isWordInDictionary)
            {
                Console.WriteLine($"The word '{userInput}' was not added to the dictionary because it already exist in the dictionary.\n");
            }

            if (!isWordInDictionary)
            {
                Console.WriteLine($"The word '{userInput}' does not exist in the dictionary.");
                Console.WriteLine("Would you like to add it to the dictionary (Y or N)?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                  
                    translation.NewMethod_AddFrenchWordToDictionary(userInput);
                }

                if (answer == "N")
                {
                    Console.WriteLine($"You have chosen not to add the word '{userInput}' to the dictionay.");
                   
                }
            }

            translation.SaveEnglishDictionaryToFile();
            translation.PrintDictionary();

            Console.ReadKey();
        }
    }
}
