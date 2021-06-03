using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLesson
{
    class Translation
    {
        //private static string key;
        //public Dictionary<string, string> wordsInDictionary;
        private string filename = @"EnglishDictionay.txt";
        public static Dictionary<string, string> wordsInDictionary = new Dictionary<string, string>();
        public string frenchWord;
        //public Dictionary<string, string> GetDictionaryData()
        //{
        //    //    string filename = @"TranslationFile.txt";
        //    //    //Dictionary<string, string> wordsInDictionary = new Dictionary<string, string>();

        //    if (File.Exists(filename))
        //    {
        //        StreamReader file = new(filename);
        //        string line = file.ReadLine();


        //        while (line != null)
        //        {

        //            String[] words = line.Split(';');

        //            foreach (string item in words)
        //            {
        //                String[] meaningOfWord = item.Split(':');
        //                string key = meaningOfWord[0];
        //                string value = meaningOfWord[1];

        //                Console.WriteLine("Please enter an English word: ");
        //                // key = Console.ReadLine();
        //                //Console.WriteLine($"The French word for '{key}' is '{value}'");

        //                //it's correct when i declare while loop?
        //                // or i don't need to declare a while loop ?
        //                while (key != value)
        //                {

        //                    key = Console.ReadLine();

        //                    // if this code is  correct 
        //                    // what i should write after "." ?
        //                    //if (!string.(key, out value))
        //                    //{
        //                    //    Console.WriteLine("Please enter alphabetic characters only, with 3 characters or more");

        //                    //    continue;
        //                    //}




        //                    if (key != value)
        //                    {
        //                        Console.WriteLine("Sorry, this word is too short. Please enter a word with 3 characters or more");

        //                    }
        //                }

        //                Console.WriteLine($"The French word for '{key}' is '{value}'");

        //                Console.WriteLine("This word does not exist in the dictionary");

        //                Console.WriteLine(" Would you like to add it to the dictionary(Y or N) ? ");

        //                string answer = Console.ReadLine().ToUpper();

        //                if (answer == "Y")
        //                {
        //                    Console.WriteLine("Please enter an English word, separated by ':'  ");
        //                    StreamWriter sw = new StreamWriter(filename);
        //                    sw.WriteLine(item);
        //                    sw.Close();
        //                    Console.WriteLine($"The word '{key}' has been added to the dictionary");
        //                    continue;
        //                }
        //                else if (answer == "N")
        //                {
        //                    Console.WriteLine($"You have chosen not to add the '{value}' to the dictionay");
        //                    continue;
        //                }

        //            }
        //            //            line = file.ReadLine();

        //        }
        //        //        file.Close();
        //    }
        //}   // return wordsInDictionary;
        //    //}



        public static bool VerifyWordInDictionary(string userInput)
        {
            // If 'userInput' exists in the dictionary, the program return true
            // If 'userInput' does not exist in the dictionary, the program return false

            // This variable 'wordsInDictionary' will always be empty, because it is declared inside the method.
            // So, to make accessible, I have moved to the top and made it public.

            bool keyExists = wordsInDictionary.ContainsKey(userInput);
            if (keyExists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddWordToDictionary(string userInput, bool isWordInDictionary)
        {
            
            
            if (isWordInDictionary == false)
            {
                Console.WriteLine("This word does not exist in the dictionary.");

                Console.WriteLine("Would you like to add it to the dictionary (Y or N)?");
                string answer = Console.ReadLine().ToUpper();
                //question 1:
                if (answer == "Y")
                {
                    Console.WriteLine("Please enter a french word for this English word:");
                    string frenchWord = Console.ReadLine();
                    StreamWriter sw = new StreamWriter(filename);
                    sw.WriteLine(userInput, frenchWord);
                    sw.Close();
                    Console.WriteLine($"The word '{userInput}' has been added to the dictionary");
                }
                if (answer == "N")
                {
                   
                        Console.WriteLine($"You have chosen not to add the word '{userInput}' to the dictionay.");
                   
                }
            }
            // question 2:
            if (isWordInDictionary == true)
            {

                StreamReader file = new(filename);
                string line = file.ReadLine();
                while (line != null)
                {

                    String[] words = line.Split(';');

                    foreach (string item in words)
                    {
                        String[] meaningOfWord = item.Split(':');

                        string value = meaningOfWord[0];
                        Console.WriteLine($"The French word for '{userInput}' is '{value}'");
                    }
                }
                file.Close();
                foreach (char t in userInput)
                {
                   Console.WriteLine($"The French word for '{t}' is '{frenchWord}'");
                }

            }
        }
    }
}