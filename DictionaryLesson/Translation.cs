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
        private static string fileName = @"EnglishDictionay.txt";
        public static Dictionary<string, string> wordsInDictionary = new Dictionary<string, string>();
        public string frenchWord;

        
        public void PrintFileToScreen()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            string fileRelativePath = Path.Combine(startupPath, fileName);
            using (StreamReader sr = File.OpenText(fileRelativePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void LoadFileToDictionary()
        {
            StreamReader file = new(fileName);
            string line = file.ReadLine();

            while (line != null)
            {
                String[] meaningOfWord = line.Split(':');
                string  key = meaningOfWord[0];
                string value = meaningOfWord[1];
                wordsInDictionary.Add(key, value);
                line = file.ReadLine();
                
            }
        }

        public static bool VerifyWordInDictionary(string userInput)
        {
            // If 'userInput' exists in the dictionary, the program return true
            // If 'userInput' does not exist in the dictionary, the program return false

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
            //if (isWordInDictionary == true)
            //{
            //    Console.WriteLine($"The word '{userInput}' was not added to the dictionary because it already exist in the dictionary.\n");
            //    return;
            //}

            if (isWordInDictionary == false)
            {
                Console.WriteLine("This word does not exist in the dictionary.");
                Console.WriteLine("Would you like to add it to the dictionary (Y or N)?");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    NewMethod_AddWordToDictionary(userInput);
                    return;
                }
                if (answer == "N")
                {

                    Console.WriteLine($"You have chosen not to add the word '{userInput}' to the dictionay.");
                    Console.WriteLine("Would you like to enter another word?");
                    answer = Console.ReadLine().ToUpper();

                    while (true)
                    {
                        if (answer == "N")
                        {
                            Console.WriteLine("Thank you for using the dictionary , you can close the app with any key");
                            Console.ReadKey();
                        }

                        if (answer == "Y")
                        {
                            StringProcessing.GetValidInput();
                            continue;
                        }
                    }
                }
            }
        }

        public void NewMethod_AddWordToDictionary(string userInput)
        {
            Console.WriteLine("Please enter a french word for this English word:");
            frenchWord = Console.ReadLine();
            wordsInDictionary.Add(userInput, frenchWord);
            Console.WriteLine($"The word '{userInput}' has been added to the dictionary");
        }

        public void PrintDictionary()
        {
            string output = "";
            foreach (KeyValuePair<string, string> kvp in wordsInDictionary)
            {
                output = output + string.Format("'{0}':'{1}'", kvp.Key, kvp.Value) + "\n";

            }
            Console.WriteLine("Here are the current words in the dictionary:\n");
            Console.WriteLine(output);
        }
       
        

        public void SaveDictionaryToFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            string fileRelativePath = Path.Combine(startupPath, fileName);

            using (StreamWriter w = File.CreateText(fileRelativePath))
            {
                foreach (var entry in wordsInDictionary)
                {
                    w.WriteLine("{0}:{1}", entry.Key, entry.Value);
                }
            }
        }
       
    }
}

