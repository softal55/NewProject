using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLesson
{
    class FrenchDictionary
    {
        public static void frenchDictionary()
        {
            bool terminateProgram = false;
            Translation translation = new Translation();
            while (terminateProgram == false)
            {
                Console.WriteLine("Would you like to update the dictionary or use it?");
                Console.WriteLine("To update, Enter 1");
                Console.WriteLine("To use it, enter 2");
                Console.WriteLine("To exit, enter 3");
                int i = int.Parse(Console.ReadLine());
                if (i == 3)
                {
                    terminateProgram = true;
                }
                if (i == 1)
                {

                    translation.LoadFrenchFileToDictionary();

                    bool updateDictionary = true;
                    string answer;
                    do
                    {
                        FrenchManage.ManageFrenchDictionary(translation);
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

                    translation.LoadFrenchFileToDictionary();

                   
                    Dictionary<string, string> englishDictionary = translation.GetDictionary();

               
                    string userInput = EnterFrenchWord.enterFrenchWord();
                    string translatedWord;
                    if (englishDictionary.ContainsKey(userInput))
                    {
                        translatedWord = englishDictionary[userInput];
                        Console.WriteLine($"The translation of the word '{userInput}' is '{translatedWord}'");
                    }
                    else
                    {
                        Console.WriteLine("The word you entered is not in the dictionary");
                    }
                }
            }
        }
    }
}
