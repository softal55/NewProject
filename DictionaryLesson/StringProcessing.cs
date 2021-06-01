using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DictionaryLesson
{
    public static class StringProcessing
    {
        // private static string key;
        //   private static string value;

        // Task 1.
        // This metho reads an input from the valides the input string as follows.
        //
        //     1.1
        //     If the user enters a word with 2 characters or less, the system displays
        //     Sorry, this word is too short. Please enter a word with 3 characters or more.
        //
        //     1.2.
        //     If the user enters non-alphabetic characters (like 1, 2, $, %, *, and so on), the system displays:
        //     Please enter alphabetic characters only, with 3 characters or more.

        // Complete the method.
        public static string GetValidInput()
        {
            string userInput;
            Console.WriteLine("please enter word : ");
            userInput = Console.ReadLine();

            // I wanna to return when it's not correct
            // I mean what i wrote it does not appear in the result
            // like when we use bool we return false or true
           
                foreach (char s in userInput)
                {
                    if (!char.IsLetter(s))
                    {
                        Console.WriteLine("Please enter alphabetic characters only, with 3 characters or more.");
                       
                    }

                }
                
                if (userInput.Length < 2)
                {
                    Console.WriteLine("Sorry, this word is too short. Please enter a word with 3 characters or more.");
                    
                }

            return userInput;
        }
    }
}

            
        
    

