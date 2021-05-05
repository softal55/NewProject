using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class PrintList
    {
        public static void Print(List<Car> cars)
        {
            // There is a C# contruct called foreach
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
          // if something is not good tell me , to review it
          // This looks good :)

        }
    }
}
