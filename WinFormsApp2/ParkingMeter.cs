using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingTicketSimulator
{

    // Used to simulate a parking meter and logs the amount of purchased minutes.
    internal class ParkingMeter
    {
        private int purchasedTime;

        // Constructor
        public ParkingMeter(int time)
        {
            purchasedTime = time;
        }

        // Purchase Time Property
        public int PurchasedTime
        {
            get { return purchasedTime; }
            set { purchasedTime = value; }
        }
    }
}
