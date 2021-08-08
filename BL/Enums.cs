using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BL
{
   
        public enum VehicleType
        {
            CAR, TRUCK, AUTO, MOTORBIKE
        }

        public enum ParkingSpotType
        {
            BIKE, CAR, TRUCK, RESERVED
        }

        public enum Status
        {
            ACTIVE, BLOCKED, RESERVED, UNKNOWN
        }

        public enum ParkingTicketStatus
        {
            ACTIVE, PAID
        }

        public enum FloorNum
    {
        GROUND, FIRST, SECOND, THIRD, FOURTH, FIFTH
    }

         
    }
