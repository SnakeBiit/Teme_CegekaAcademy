using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework04.Models
{
    public class Car
    {
        public int id;
        public string carBrand;
        public string carModel;
        public string carColor;
        public int engineSize;
        public string fuel;
        public Car(int id , string carBrand, string carModel, string carColor,int engineSize, string fuel )
        {
            this.id = id;
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carColor = carColor;
            this.engineSize = engineSize;
            this.fuel = fuel;
        }
    }
}