using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task: using the switch statement
            // Watch this video:
            // https://www.youtube.com/watch?v=soKhwNYxs2I
            // 1. Read a number from the keyboard
            // 2. depending on the number entered, disply the following:
            //    Your favorite color is : COLOR
            //    for example, if the user enters 1, you diplay:
            //     Your favorite color is : RED
            // valid inputs are
            // 1 for RED
            // 2 for BLUE
            // 3 for GREEN
            // 4 for YELLOW
            // 5 for BROWN
            // 6 for WHITE
            // 7 for BLACK
            // if the user enters another value, diplay 
            // Your entered an invalid number, please try again.
            Console.WriteLine("Please enter number :");
            int FavoriteColor = int.Parse(Console.ReadLine());
            switch(FavoriteColor)
            {
                case 1:
                    Console.WriteLine("Your favorite color is : Red");
                    break;
                case 2:
                    Console.WriteLine("Your favorite color is : Blue");
                    break;
                case 3:
                    Console.WriteLine("Your Favorite color is : Green");
                    break;
                case 4:
                    Console.WriteLine("Your favorite color is : Yellow");
                    break;
                case 5:
                    Console.WriteLine("Your favorite color is : Brown");
                    break;
                case 6:
                    Console.WriteLine("Your favorite color is : White");
                    break;
                case 7:
                    Console.WriteLine("Your favorite color is : Black");
                    break;
                default:
                    Console.WriteLine(" Your entered an invalid number, please try again.");
                    countinue;

            }
        }
    }
}
