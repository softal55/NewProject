using System;
using System.Collections.Generic;
namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car(1);
            car1.Color = "Red";
            car1.Model = "Toyota";
            car1.IsSportsCar = true;

            Car car2 = new Car(2,"Honda");
            car2.Color = "Blue";
            car2.IsSportsCar = false;

            Car car3 = new Car(3 ,"Red", true);
            car3.Model = "Honda";

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
    
