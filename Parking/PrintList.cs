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
                // Print the property Id.
                Console.WriteLine("Car 1 Id {0}", car.Id);

                // now finish printing the other properties.

            }
            
        }
    }
}
