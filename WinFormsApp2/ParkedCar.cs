using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingTicketSimulator
{
    internal class ParkedCar
    {
        private string make { get; set; }
        private string model { get; set; }
        private string color { get; set; }
        private string license { get; set; }
        private int minutesParked { get; set; }

        // Constructor
        public ParkedCar(string _make, string _model, string _color, string _license, int _minutesParked)
        {
            make = _make;
            model = _model;
            color = _color;
            license = _license;
            minutesParked = _minutesParked;
        }

        // Make Property
        public string Make { 
            get { return make; }
            set { make = value; }
        }

        // Model Property
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Color Property
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // License
        public string License
        {
            get { return license; }
            set { license = value; }
        }

        public int MinutesParked
        {
            get { return minutesParked; }
            set { minutesParked = value; }
        }
    }
}
