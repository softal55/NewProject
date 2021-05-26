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
            
            List<Translation> translatedWords = new();
            if(File.Exists(filename))
            {
                StreamReader file = new(filename);
                string line = file.ReadLine();
                
                while(line != null)
                {
                    //how do i use the object Word and Meaning here 
                    
                    
     

                    line = file.ReadLine();
                }
                file.Close();
            }
            return translatedWords;
        }
    }
}
