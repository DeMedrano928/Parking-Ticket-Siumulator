using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParkingTicketSimulator
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        public void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the parking ticket.
            Close();
        }
    }
}
