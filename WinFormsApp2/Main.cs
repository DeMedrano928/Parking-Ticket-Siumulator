using ParkingTicketSimulator;
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Main : Form
    {
        class ParkedCar
        {
            public string make;
            public string model;
            public string color;
            public string license;
            public int minutesParked;

            // Constructor
            public ParkedCar(string _make, string _model, string _color, string _license, int _minutesParked)
            {
                make = _make;
                model = _model;
                color = _color;
                license = _license;
                minutesParked = _minutesParked;
            }
        }

        // Used to simulate a parking meter and logs the amount of purchased minutes.
        class ParkingMeter
        {
            public int purchasedTime;

            // Constructor
            public ParkingMeter(int time)
            {
                purchasedTime = time;
            }
        }

        // Used to simulate a parking ticket 
        class ParkingTicket
        {
            // Constructor
            public ParkingTicket(ParkedCar car, ParkingMeter meter, PoliceOfficer officer, int fine)
            {
                // Creates a new ticket form.
                var ticketForm = new Ticket();

                // Displays all information on the ticket form
                ticketForm.makeTextBox.Text = car.make;
                ticketForm.modelTextBox.Text = car.model;
                ticketForm.colorTextBox.Text = car.color;
                ticketForm.licenseTextBox.Text = car.license;
                ticketForm.nameTextBox.Text = officer.name;
                ticketForm.badgeTextBox.Text = officer.badgeNumber.ToString();
                ticketForm.purchaseTextBox.Text = meter.purchasedTime.ToString();
                ticketForm.parkedTextBox.Text = car.minutesParked.ToString();
                ticketForm.fineTextBox.Text = fine.ToString();

                ticketForm.ShowDialog();
            }
        }

        class PoliceOfficer
        {
            public string name;
            public int badgeNumber;
            
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
                var hoursPassed = (car.minutesParked - meter.purchasedTime) / 60;
                var fine = 0;

                // If the user exceeded their time limit, sets the fine to 25 dollars as a base.
                if (car.minutesParked > meter.purchasedTime)
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

            // Issues a ticket to a specific car.
            public ParkingTicket? IssueTicket(ParkedCar car, ParkingMeter meter, PoliceOfficer officer, int fine)
            {
                return new ParkingTicket(car, meter, officer, fine);
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Gets all the user's input
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;
            string color = colorTextBox.Text;
            string license = licenseTextBox.Text;
            string name = nameTextBox.Text;
            int badgeNumber = (int)badgeNumberValue.Value;
            int minutesPurchased = (int)minutesPurchasedValue.Value;
            int minutesParked = (int)minutesParkedValue.Value;

            // Creates new objects based on the user's input.
            ParkedCar car = new ParkedCar(make, model, color, license, minutesParked);
            ParkingMeter meter = new ParkingMeter(minutesPurchased);
            PoliceOfficer officer = new PoliceOfficer(name, badgeNumber);

            // Checks if a fine is applicable to the car parked
            int fine = officer.ExamineCar(car, meter);

            // If the fine is applicable, writes the car a ticket
            if (fine > 0)
            {
                officer.IssueTicket(car, meter, officer, fine);
            } else
            {
                MessageBox.Show($"Cannot write ticket, car still has {minutesPurchased-minutesParked} minutes left.");
            }

        }
    }
}
