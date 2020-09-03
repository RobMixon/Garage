using System;
using System.Collections.Generic;

namespace garage {
    public class Tesla : Vehicle, IElectricVehicle {
        public double BatteryKWh { get; set; }
        public int ChargePercentage { get; set; }

        public void ChargeBattery () {
            ChargePercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ($"The tesla goes whoosh!");
        }

        public override void Turn (string Direction) {
            Console.WriteLine ($"The tesla slides {Direction}");
        }
    }
}