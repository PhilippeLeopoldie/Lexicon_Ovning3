﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3FordonsHanteringsSystem.Vehicles
{
    internal class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }

        public override string StartEngine()
        {
            return "Truck started!";
        }

        public override string Stats()
        {
            throw new NotImplementedException();
        }
    }
}
