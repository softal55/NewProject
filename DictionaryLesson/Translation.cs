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
                      //  wordsInDictionary.Add(key, value);
                        Console.WriteLine("Please enter an English word: ");
                        key = Console.ReadLine();
                        Console.WriteLine($"The French word for '{key}' is '{value}'");
                        Console.ReadLine();
                        
                    }
                    line = file.ReadLine();
                }
                file.Close();
            }
            return wordsInDictionary;
        }
    }
}
