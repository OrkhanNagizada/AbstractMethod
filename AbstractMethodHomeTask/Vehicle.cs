using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodHomeTask
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }

        public Vehicle(int year)
        {
            if (year <= 0)
            {
                throw new ArgumentException("İl musbət  olmalidir ALLAHin mali.");
            }
            Year = year;
        }

        public abstract void ShowInfo();
    }
}
