using ParkingLot.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class API
    {
        public AvailabilityBoard GetEmptySpotsInfo()
        {
            throw new NotImplementedException();
        }

        public bool CheckSpotsAvailability(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
        public ParkingSpot SuggestParkingSpot(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
        public void AssignTicket(ParkingTicket ticket, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public AvailabilityBoard ReserveSpot(string TicketNumber, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
        public void BlockSpot(string TicketNumber, Vehicle vehicle, ParkingSpot spot)
        {
            throw new NotImplementedException();
        }
        public ParkingSpot ReleaseSpot(ParkingTicket ticket, ParkingSpot spot)
        {
            throw new NotImplementedException();
        }
        private AvailabilityBoard UpdateAvailabilityBoard(ParkingSpot spot, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        
    }
    

}
