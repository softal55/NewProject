using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class PrintList
    {
        

        public static void Print(List<Car> cars)
        {
           
            foreach (var car in cars)
            {
                Console.WriteLine("The Car Id : " + car.Id + ", Color : " + car.Color + ", Model : " + car.Model);

                if (car.IsSportsCar == true)
                {
                    Console.WriteLine("The car is a \"sports car\" ");
                }
                if (car.IsSportsCar == false)
                {
                    Console.WriteLine("The car is not a \"sports car\" ");
                }
            }
        }
        public static void  PrintCarsByColor( string Color, List<Car>cars)
        {
            Console.WriteLine("Print Cars By Color:");

            foreach (var car in cars)
            {
                Color = car.Color;
                if (Color == "Red")
                {
                    Console.WriteLine("The Car Id : " + car.Id + ", Color : " + car.Color + ", Model : " + car.Model);
                }
                if (Color != "Red")
                { 
                   Console.WriteLine(" The list has no red colors");
                }
            }
        }
    }
}





    


