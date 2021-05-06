using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Car
    {
       public int Id;
       public  string Color;
        public string Model;
        public bool IsSportsCar;

        // Note that this constructor take 4 parameter.
        public Car(int id, string color, string model , bool isSportsCar)
        {
            Id = id;
            Color = color;
            Model = model;
            IsSportsCar = isSportsCar;
        }

        // In C#, a class can have more than 1 constructor
        // Add 3 more contructors to this class
        // Constructor 1. A constructor that takes 1 paramater (Id)
        // Constructor 2. A constructor that takes 2 parameters (Id, Model)
        // Constructor 3. A constructor that takes 3 paramaters (Id, Color, isSportsCar)

        // Then, in your main program,
        // Change car1 to use 'Constructor 1'
        // Then use assinments to add the other 3 paramters
        //
        // Change car2 to use 'Constructor 2'
        // Then use assingments to add the other 2 paramaters

        // Change car3 to use 'Constructor 3'
        // Then use assingments to add the other paramater

        // Keep  car4 

    }
}
