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
            // NOTE: 
            // Place a breakpoint at the next line (line 39)
            // Then trace the execution with F11
            // hover over the variables to see their value
            // 
            StreamReader file = new(fileName);
            string line = file.ReadLine();
            // Hint: 
            // Set a breakpoint at line 34 
            // Use F11 to trace the execution of this method.
            // Watch these videos to learn more about F10, F11, and F12
            // Video 1:
            // https://www.youtube.com/watch?v=QCPt9aOcd98
            //
            // Video 2:
            // https://www.youtube.com/watch?v=yFH4GhZIss4
            //
            // If you cannot find the bug today, I will give you a hint tomorrow :)
            // 
            while (line != null)
            {
                // 1. When line = House: Maison;
                String[] words = line.Split(';');
                // 2. Since we are splitting the line at ';'
                // words[0] = House: Maison
                // words[1] = ""
                foreach (string item in words)
                {
                    // 1. First time inside this loop
                    // 1.1 item is  'House: Maison'
                    String [] meaningOfWord = item.Split(':');
                    // 1.2. Since we are splitting on the ':'
                    // 1.3 meaningOfWord[0] = House
                    // 1.4 meaningOfWord[1] = Maison
                    string key = meaningOfWord[0]; 
                    // 1.5 key = House
                    string value= meaningOfWord[1];
                    // 1.6 value = Maison
                    wordsInDictionary.Add(key , value);

                    //// 2. Second time inside this loop
                    //// 2.1 item is  ""
                    //String[] meaningOfWord = item.Split(':');
                    //// 2.2. We are splitting on the ':'
                    ///       BUT this time, 'item' is "" which is null, so 
                    //// 2.3 meaningOfWord[0] = null  this OK.
                    //// 2.4 meaningOfWord[1] = does not exist!!! bug 
                    //string key = meaningOfWord[0];
                    //// 2.5 key = "" 
                    //string value = meaningOfWord[1];
                    //// 2.6 value = DOES NOT EXIST!!!
                    //wordsInDictionary.Add(key, value);
                }
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
            if (isWordInDictionary == true)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
                string fileRelativePath = Path.Combine(startupPath, fileName);
                using (StreamReader sr = File.OpenText(fileRelativePath))
                {

                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine($"The word {userInput} is  exist in the dictionary.");
                    }
                }
            }

            if (isWordInDictionary == false)
            {

                Console.WriteLine("This word does not exist in the dictionary.");

                Console.WriteLine("Would you like to add it to the dictionary (Y or N)?");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    Console.WriteLine("Please enter a french word for this English word:");
                    frenchWord = Console.ReadLine();
                    wordsInDictionary.Add(userInput, frenchWord);
                    Console.WriteLine($"The word '{userInput}' has been added to the dictionary");
                    while (true)
                    {
                        Console.WriteLine("Would you like to enter another word?");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "N")
                        {
                            Console.WriteLine("Thank you for using the dictionary , you can close the app with any key");
                            Console.ReadKey();
                        }

                        if (answer == "Y")
                        {
                           // question :
                           // give me some hints to finish this :
                            StringProcessing.GetValidInput();
                            continue;

                        }
                    }
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
    

        
            public void PrintDictionary()
            {
                string output = "";
                foreach (KeyValuePair<string, string> kvp in wordsInDictionary)
                {
                    output = output + string.Format("The French word for '{0}' is '{1}'", kvp.Key, kvp.Value);

                }
                Console.WriteLine(output);
            }

            public void SaveDictionaryToFile()
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string startupPath = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
                string fileRelativePath = Path.Combine(startupPath, fileName);

                using (StreamWriter w = File.AppendText(fileRelativePath))
                {
                    foreach (var entry in wordsInDictionary)
                    {
                        w.WriteLine("{0}: {1};", entry.Key, entry.Value);
                    }
                }
            }
    }
}

