using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodHomeTask
{
    class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Car(int year, string brand, string model, int maxSpeed) : base(year)
        {
            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model))
            {
                throw new ArgumentException("Brand Ve Model Yazilmalidir");
            }
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car - Year: {Year}, Color: {Color}, Brand: {Brand}, Model: {Model}, Max Speed: {MaxSpeed}");
        }
    }
}
