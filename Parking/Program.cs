using System;
using System.Collections.Generic;
namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
           
            car1.Id = 1;
            car1.Color = "Red";
            car1.Model = "Toyota";
            car1.IsSportsCar = true;

            Car car2 = new Car();
            car2.Id = 2;
            car2.Color = "Blue";
            car2.Model = "Honda";
            car2.IsSportsCar = false;

            Car car3 = new Car();
            car3.Id = 3;
            car3.Color = "Red";
            car3.Model = "Honda";
            car3.IsSportsCar = true;

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

            // Implement a method to print the list of cars
            // the method takes a list cars and returns an integer indicating the number
            // of cars that the method printed.
            // Create a new file that holds the class which contains the method that displays the cars
            // The method display the cars like this:
            // Car 1:
            //     Id = 4;
            //      Color = "Green";
            //      Model = "Hyundai";
            //      IsSportsCar = false;
            // Car 2:
            // ...
            
            



        }
    }
}
    
