using System;

namespace garage {
    public interface IGasVehicle {
        int TankPercentage { get; set; }
        public void RefuelTank () {

        }
    }
}