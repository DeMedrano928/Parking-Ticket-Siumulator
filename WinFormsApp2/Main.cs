using ParkingTicketSimulator;
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Main : Form
    {
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
