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
       
        public Car(int id, string color, string model , bool isSportsCar)
        {
            Id = id;
            Color = color;
            Model = model;
            IsSportsCar = isSportsCar;
        }
    }
}
