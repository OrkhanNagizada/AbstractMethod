using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodHomeTask
{
    class Bus : Vehicle
    {
        public int PassengerCount { get; set; }

        public Bus(int year, int passengerCount) : base(year)
        {
            PassengerCount = passengerCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Bus - Year: {Year}, Color: {Color}, Passenger Count: {PassengerCount}");
        }
    }

}
