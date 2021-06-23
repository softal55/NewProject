using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLesson
{
    class EnterFrenchWord
    {
        public static string enterFrenchWord()
        {
            int minimumLenghth = 2;

            while (true)
            {
                Console.WriteLine("Please enter a French word : ");
                string userInput = Console.ReadLine();

                if (userInput.Length > minimumLenghth)
                {

                    if (userInput.All(char.IsLetter))
                    {
                        return userInput;
                    }
                    else
                    {
                        Console.WriteLine("\nSorry, invalid inpt!!!");
                        Console.WriteLine("Please enter alphabetic strings only, with 3 characters or more.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, this word is too short. Please enter a word with 3 characters or more.");
                }
            }
        }
    }
}
