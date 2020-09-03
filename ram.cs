using System;
using System.Collections.Generic;

namespace garage {
    public class Ram : Vehicle, IGasVehicle {
        public double FuelCapacity { get; set; }
        public int TankPercentage { get; set; }

        public void RefuelTank () {
            TankPercentage = 97;
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} ram drives past. Rummmbbbllee");
        }
    }
}