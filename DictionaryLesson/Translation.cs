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

        public static Dictionary<string, string> GetDictionaryData()
        {
            string filename = @"TranslationFile.txt";
            Dictionary<string, string> wordsInDictionary = new Dictionary<string, string>();

            if (File.Exists(filename))
            {
                StreamReader file = new(filename);
                string line = file.ReadLine();
                
               
                while (line != null)
                {
                    
                    String[] words = line.Split(';');
                    
                    foreach (string item in words)
                    {
                        String[] meaningOfWord = item.Split(':');
                        string key= meaningOfWord[0];                      
                        string value = meaningOfWord[1];

                        Console.WriteLine("Please enter an English word: ");
                        // key = Console.ReadLine();
                        //Console.WriteLine($"The French word for '{key}' is '{value}'");
                        while (key != value)
                        {

                            key = Console.ReadLine();

                            if (!string.(key, out value))
                            {
                                Console.WriteLine("Please enter alphabetic characters only, with 3 characters or more");

                                continue;
                            }




                            if (key != value)
                            {
                                Console.WriteLine("Sorry, this word is too short. Please enter a word with 3 characters or more");
                                
                            }
                        }     
                        
                       // Console.WriteLine($"The French word for '{key}' is '{value}'");

                        Console.WriteLine("This word does not exist in the dictionary");
                        
                        Console.WriteLine(" Would you like to add it to the dictionary(Y or N) ? ");

                        string answer = Console.ReadLine().ToUpper();

                        if (answer == "Y")
                        {
                            Console.WriteLine("Please enter an English word, separated by ':'  ");
                            StreamWriter sw = new StreamWriter(filename);
                            sw.WriteLine(item);
                            sw.Close();
                            Console.WriteLine($"The word '{key}' has been added to the dictionary");
                            continue;
                        }
                        else if (answer == "N")
                        {
                            Console.WriteLine($"You have chosen not to add the '{value}' to the dictionay");
                            continue;
                        }
                       
                    }
                    line = file.ReadLine();
                   
                }
                file.Close();
            }
            return wordsInDictionary;
        }
    }
}
