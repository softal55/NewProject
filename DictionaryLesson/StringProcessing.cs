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
        //     1.1.
        //     If the user enters a word with 2 characters or less, the system displays
        //     Sorry, this word is too short. Please enter a word with 3 characters or more.
        //
        //     1.2.
        //     If the user enters non-alphabetic characters (like 1, 2, $, %, *, and so on), the system displays:
        //     Please enter alphabetic characters only, with 3 characters or more.

        public static string GetValidInput()
        {

            int  minimumLenghth = 2;

            while (true)
            {
                Console.WriteLine("please enter a english word : ");
                string userInput = Console.ReadLine();

                //  1.1
                //  If the user enters a word with 2 characters or less, the system displays
                //  Sorry, this word is too short. Please enter a word with 3 characters or more.
                if (userInput.Length > minimumLenghth)
                {
                    //
                    //  1.2
                    //  If the user enters non-alphabetic characters (like 1, 2, $, %, *, and so on), the system displays:
                    //  Please enter alphabetic characters only, with 3 characters or more.
                    if (userInput.All(char.IsLetter)) // Accept letters only
                    {
                        // This a good string. It has letters only!
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





