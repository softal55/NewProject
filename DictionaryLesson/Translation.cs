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
        private static string EnglishFile = @"EnglishDictionay.txt";
        private static string FrenchFile = @"FrenchDictionary.txt";
        public static Dictionary<string, string> wordsInDictionary = new Dictionary<string, string>();
        public string frenchWord;
        public string englishWord;

        public void PrintEnglishFileToScreen()
        { 
            string currentDirectory = Directory.GetCurrentDirectory();
            string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            string fileRelativePath = Path.Combine(startupPath, EnglishFile);
            using (StreamReader sr = File.OpenText(fileRelativePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintFrenchFileToScreen()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            string fileRelativePath = Path.Combine(startupPath, FrenchFile);
            using (StreamReader sr = File.OpenText(fileRelativePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        private bool E = false;
        public void LoadEnglishFileToDictionary()
        {
            if (!E)
            {
                StreamReader file = new(EnglishFile);
                string line = file.ReadLine();

                while (line != null)
                {
                    String[] meaningOfWord = line.Split(':');
                    string key = meaningOfWord[0];
                    string value = meaningOfWord[1];
                    wordsInDictionary.Add(key, value);
                    line = file.ReadLine();
                }
                file.Close();
                E = true;
            }  
        }

        private bool F = false;
        public void LoadFrenchFileToDictionary()
        {
            if (!F)
            {
                StreamReader file = new(FrenchFile);
                string line = file.ReadLine();

                while (line != null)
                {
                    String[] meaningOfWord = line.Split(':');
                    string key = meaningOfWord[0];
                    string value = meaningOfWord[1];
                    wordsInDictionary.Add(key, value);
                    line = file.ReadLine();
                }
                file.Close();
                F = true;
            }
        }

        public static bool VerifyWordInDictionary(string userInput)
        {
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

        public void AddFrenchWordToDictionary(string userInput, bool isWordInDictionary)
        {
            if (isWordInDictionary == false)
            {
               
                Console.WriteLine("This word does not exist in the dictionary.");
                Console.WriteLine("Would you like to add it to the dictionary (Y or N)?");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    NewMethod_AddFrenchWordToDictionary(userInput);
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
                            EnterFrenchWord.enterFrenchWord();
                            continue;
                        }
                    }
                }
            }
        }
        public void AddEnglishWordToDictionary(string userInput, bool isWordInDictionary)
        {
            if (isWordInDictionary == false)
            {

                Console.WriteLine("This word does not exist in the dictionary.");
                Console.WriteLine("Would you like to add it to the dictionary (Y or N)?");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    NewMethod_AddEnglishWordToDictionary(userInput);
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
                            EnterEnglishWord.enterEnglishWord();
                            continue;
                        }
                    }
                }
            }
        }

        public void NewMethod_AddFrenchWordToDictionary(string userInput)
        {
            Console.WriteLine("Please enter a french word for this English word:");
            frenchWord= Console.ReadLine();
            wordsInDictionary.Add(userInput, frenchWord);
            Console.WriteLine($"The word '{userInput}' has been added to the dictionary");
        }
        public void NewMethod_AddEnglishWordToDictionary(string userInput)
        {
            Console.WriteLine("Please enter a English word for this french word:");
            englishWord = Console.ReadLine();
            wordsInDictionary.Add(userInput, englishWord);
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
       
        public void SaveEnglishDictionaryToFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            string fileRelativePath = Path.Combine(startupPath, EnglishFile);

            using (StreamWriter w = File.CreateText(fileRelativePath))
            {
                foreach (var entry in wordsInDictionary)
                {
                    w.WriteLine("{0}:{1}", entry.Key, entry.Value);
                }
            }
        }

        public void SaveFrenchDictionaryToFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            string fileRelativePath = Path.Combine(startupPath, FrenchFile);

            using (StreamWriter w = File.CreateText(fileRelativePath))
            {
                foreach (var entry in wordsInDictionary)
                {
                    w.WriteLine("{0}:{1}", entry.Key, entry.Value);
                }
            }
        }

        public Dictionary<string, string> GetDictionary()
        {
            return wordsInDictionary;
        }
    }
}

