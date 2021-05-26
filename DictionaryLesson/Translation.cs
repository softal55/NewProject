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
        public string Word;
        public string Meaning;
        
        public static List<Translation> GetDictionaryData(string filename)
        {
            // Hint 1
            // define  a dictinary  called 'wordsInDictionary' of type <string, string>
            Dictionary<string, string> wordsInDictionary = new Dictionary<string, string>();
             
            List<Translation> translatedWords = new();
            if(File.Exists(filename))
            {
                StreamReader file = new(filename);
                string line = file.ReadLine();
                
                while(line != null)
                {
                    //how do i use the object Word and Meaning here 
                    // Now you split the line at the ";"
                    String [] words = line.Split(';');
                    foreach (string item in words)
                    {
                        // Now, each item looks like this...
                        // House:Maison
                        // So, we split the item at the ':"
                        // Declare an array called 'meaningOfWord' to hold the items we just split
                        // Now, meaningOfWord[0] is the key and meaningOfWord[1] is the value.
                        // so, add the <key, value> to the dictionary 'wordsInDictionary'
                        // declare 2 variables of type string 
                        // string key = holds the key, which is meaningOfWord[0]
                        // string value = holds the key, which is meaningOfWord[1]
                        // Now add the <key, value>; pair to the dictionary.
                    }



                    line = file.ReadLine();
                }
                file.Close();
            }
            return translatedWords;
        }
    }
}
