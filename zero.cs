using System;

namespace garage {
    public class Zero : Vehicle, IElectricVehicle {
        public double BatteryKWh { get; set; }
        public int ChargePercentage { get; set; }

        public void ChargeBattery () {
            ChargePercentage = 100;
        }
    }
}