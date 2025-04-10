using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3FordonsHanteringsSystem.Vehicles
{
    internal class Car : Vehicle
    {

        public double BatteryRange { get; set; }

        public Car(string brand, string model, int year, double weight, double batteryRange) : base (brand,model, year, weight)
        {
            BatteryRange = batteryRange;
        }
        

        public override string StartEngine()
        {
            return "Car started!";
        }

        public override string Stats()
        {
            return $"{this}, battery range: {this.BatteryRange}";
        }
    }
}
