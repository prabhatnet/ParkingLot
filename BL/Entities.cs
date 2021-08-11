using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BL
{
        public class Telemachine
        {
        public int TelemachId { get; set; }
           
        }
        public class Customer
        {
        public int id { get; set; }
        public string Name { get; set; }
        public string CarNumber { get; set; }
           
        }
        public class System
        {
      
        }
       public class ParkingTicket
        {
           public Vehicle vehicle { get; set; }
        }
}
