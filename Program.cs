using System;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* ENTITIES-----------------------
             * 1. TeleMachine (Assigning ticket)
             * 2. Customer
             * 3. System (Taking account of Spot busy/available
             * 4. Parking Floor
             * 5  Parking Slot
             * 
             * USE CASES------------------------
             * 1.Block/Free parking spot: To block, free a parking spot on a floor.
             * 2. Get Ticket: Customers get a new parking ticket at telemachine.
             *  (i) Check Availability using AI tool
             *  (ii) Suggest parking number and floor
             *  (iii) Remove availability
             *  (iV) Remove spot basesd on sensor
             * 3. Pay Ticket
             *   (i) Payment
             *   (ii) Exit
             *   (iii) Add parking slot
             *   
             * */
        }
    }
}
