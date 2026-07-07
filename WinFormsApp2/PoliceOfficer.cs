using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingTicketSimulator
{
    internal class PoliceOfficer
    {
        private string name { get; set; }
        private int badgeNumber { get; set; }

        // Constructor
        public PoliceOfficer(string _name, int _badgeNumber)
        {
            name = _name;
            badgeNumber = _badgeNumber;
        }

        // Determines if the car is parked over time.
        public int ExamineCar(ParkedCar car, ParkingMeter meter)
        {
            // Used to determine the total fine based on the car's parking expiration.
            var hoursPassed = (car.MinutesParked - meter.PurchasedTime) / 60;
            var fine = 0;

            // If the user exceeded their time limit, sets the fine to 25 dollars as a base.
            if (car.MinutesParked > meter.PurchasedTime)
            {
                fine = 25;

                // Adds 10 dollars for each hour passed after expiration.
                for (int i = 0; i < hoursPassed; i++)
                {
                    fine += 10;
                }
            }

            return fine;
        }

        // Name Property
        public string Name
        {  
            get { return name; } 
            set { name = value; }
        }

        // Badge Number Property
        public int BadgeNumber
        {
            get { return badgeNumber; }
            set { badgeNumber = value; }
        }

        // Issues a ticket to a specific car.
        public ParkingTicket? IssueTicket(ParkedCar car, ParkingMeter meter, PoliceOfficer officer, int fine)
        {
            return new ParkingTicket(car, meter, officer, fine);
        }
        
    }
}
