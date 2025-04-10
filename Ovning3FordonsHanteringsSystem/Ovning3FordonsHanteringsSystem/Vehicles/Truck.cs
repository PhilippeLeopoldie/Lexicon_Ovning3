using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3FordonsHanteringsSystem.Vehicles
{
    internal class Truck : Vehicle, ICleanable
    {
        public double CargoCapacity { get; set; }

        public Truck (string brand, string model, int year, double weight, double cargoCapacity) : base(brand, model, year, weight)
        {
            CargoCapacity = cargoCapacity;
        }
        public override string StartEngine()
        {
            return "Truck started!";
        }

        public override string Stats()
        {
            return $"{this}, cargo capacity: {this.CargoCapacity}";
        }

        public void Clean()
        {
            Util.Log("The truck is cleaned!");
        }
    }
}
