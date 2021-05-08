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
       public Car(int id)
       {
            Id = id;
       }
       public Car(int id, string model)
       {
            Id = id;
            Model = model;
       }
       public Car(int id, string color, bool isSportsCar)
       {
            Id = id;
             Color = color;
             IsSportsCar = isSportsCar;
       }
       

    }
}
