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
        public static List<string> ReadFile(string filename)
        {
            List<string> wordsInFile = new();
            if (File.Exists(filename))
            {
                StreamReader file = new(filename);
                string line = file.ReadLine();
                while (line != null)
                {
                    wordsInFile.Add(line);
                    line = file.ReadLine();

                }
                file.Close();
                
                
            }
            return wordsInFile;
        }
        public static int GetNumberOfWords(List<string> wordsInFile)
        {
           int numberOfWords = wordsInFile.Count();
            return  numberOfWords;
        }
    }
}
