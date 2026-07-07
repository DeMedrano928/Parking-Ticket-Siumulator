using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingTicketSimulator
{
    // Used to simulate a parking ticket 
    internal class ParkingTicket
    {     
         // Constructor
        public ParkingTicket(ParkedCar car, ParkingMeter meter, PoliceOfficer officer, int fine)
        {
            // Creates a new ticket form.
            var ticketForm = new Ticket();

            // Displays all information on the ticket form
            ticketForm.makeTextBox.Text = car.Make;
            ticketForm.modelTextBox.Text = car.Model;
            ticketForm.colorTextBox.Text = car.Color;
            ticketForm.licenseTextBox.Text = car.License;
            ticketForm.nameTextBox.Text = officer.Name;
            ticketForm.badgeTextBox.Text = officer.BadgeNumber.ToString();
            ticketForm.purchaseTextBox.Text = meter.PurchasedTime.ToString();
            ticketForm.parkedTextBox.Text = car.MinutesParked.ToString();
            ticketForm.fineTextBox.Text = fine.ToString();

            ticketForm.ShowDialog();
        }
        
    }
}
