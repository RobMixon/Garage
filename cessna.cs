using System;
using System.Collections.Generic;

namespace garage {
    public class Cessna : Vehicle, IGasVehicle {
        public double FuelCapacity { get; set; }
        public int TankPercentage { get; set; }

        public void RefuelTank () {
            TankPercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ("Zoooooom nerds!");
        }
        public override void Stop () {
            Console.WriteLine ("The Cessna rolls to a stop");
        }

        public override void Turn (string Direction) {
            Console.WriteLine ($"The Cessna turns {Direction}");
        }
    }
}