using System;

namespace garage {
    public interface IElectricVehicle {
        int ChargePercentage { get; set; }

        public void ChargeBattery () {
            ChargePercentage = 100;
        }
    }

}