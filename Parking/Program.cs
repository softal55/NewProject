using System;
using System.Collections.Generic;
namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car(1,"Red", "Toyota", true);
          
            Car car2 = new Car(2, "Blue", "Honda", false);
            
            Car car3 = new Car(3 ,"Red", "Honda", true);
            
            Car car4 = new Car(4, "Green", "Hyundai", false);
            

            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);

            PrintList.Print(cars);

        }
    }
}
    
