using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BL
{
 
    public abstract class ParkingSpot
    {
        public int Number { get; set; }
        public FloorNum Floor { get; set; }
        public Vehicle Vehicl { get; set; }
        public bool IsFree { get; set; }
        public ParkingSpotType SpotType { get; set; }
         
     }
    public class BikeSpot : ParkingSpot
    {
        public BikeSpot()
        {
            base.SpotType = ParkingSpotType.BIKE;
        }
    }

    public class CarSpot : ParkingSpot
    {
        public CarSpot()
        {
        base.SpotType = ParkingSpotType.CAR;
        }
    }

    public class TruckSpot : ParkingSpot
    {
        public TruckSpot()
        {
            base.SpotType = ParkingSpotType.TRUCK;
        }
    }

    public class ReservedSpot : ParkingSpot
    {
        public ReservedSpot()
        {
            base.SpotType = ParkingSpotType.RESERVED;
        }
    }
      
}
