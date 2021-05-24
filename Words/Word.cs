using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Word
    {

        // Here is an example.
        //https://www.javatpoint.com/program-to-find-the-number-of-words-in-the-given-text-file 
        // The article uses many languages. For you, look for the section written in C#
        // 
        // Here is another example
        // https://www.youtube.com/watch?v=4IZFP3p6Oh8
        // 
        // The files contains only words and spaces. No other symbols like ',', '.' '?' or anything else.
        // 
        // You need to split the line into words.
        // Here is an example
        // https://www.codegrepper.com/code-examples/csharp/c%23+string+split+split+options+and+store+in+list
        // 
        public static List<string> ReadFile(string filename)
        {
          
            List<string> wordsInFile = new();
            if (File.Exists(filename))
            {
                StreamReader file = new(filename);
                string line = file.ReadLine();
                while (line != null)
                {
                   String[] words = line.Split(' ');
                    foreach(string word in words)
                    {
                        wordsInFile.Add(word);
                    }
                    line = file.ReadLine();  
                }
                
                file.Close();
            }
            return wordsInFile;
        }
        public static int GetNumberOfWords(List<string> wordsInFile)
        {   
            int numberOfWords = wordsInFile.Count;
          
            return  numberOfWords;
        }
        
    }
    
    
}
