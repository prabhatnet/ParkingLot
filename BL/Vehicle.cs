using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BL
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
            this.vehicleType = VehicleType.CAR; // default
        }
        public string LicenseNumber { get; set; }
        public VehicleType vehicleType { get; set; }
        public ParkingTicket parkingTicket { get; set; }
        public FloorNum Floor { get; set; }

    }

    public class Car : Vehicle
    {
        public Car()
        {
            base.vehicleType = VehicleType.CAR;
        }
    }

    public class Bike : Vehicle
    {
        public Bike()
        {
            base.vehicleType = VehicleType.MOTORBIKE;
        }
    }

    public class Truck : Vehicle
    {
        public Truck()
        {
            base.vehicleType = VehicleType.TRUCK;
            base.Floor = FloorNum.GROUND;
        }
    }

    public class Auto : Vehicle
    {
        public Auto()
        {
            base.vehicleType = VehicleType.AUTO;
        }
    }

}
