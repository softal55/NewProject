using System;
using System.Collections.Generic;
namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Watch this video
            // https://www.youtube.com/watch?v=Reeefq-Nxkk
            // 

            // Task objective: learn how to use constructors in c#
            // 
            // Replace the lines to create 'car1' with a constructors.
            Car car1 = new Car();
            car1.Id = 1;
            car1.Color = "Red";
            car1.Model = "Toyota";
            car1.IsSportsCar = true;

            // Replace the lines to create 'car2' with a constructors.
            Car car2 = new Car();
            car2.Id = 2;
            car2.Color = "Blue";
            car2.Model = "Honda";
            car2.IsSportsCar = false;

            // Replace the lines to create 'car3' with a constructors.
            Car car3 = new Car();
            car3.Id = 3;
            car3.Color = "Red";
            car3.Model = "Honda";
            car3.IsSportsCar = true;

            // Replace the lines to create 'car4' with a constructors.
            Car car4 = new Car();
            car4.Id = 4;
            car4.Color = "Green";
            car4.Model = "Hyundai";

            car4.IsSportsCar = false;
            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);

            // Since we want to print the list of cars, we need to pass that list to the method as follows.
            PrintList.Print(cars);

        }
    }
}
    
