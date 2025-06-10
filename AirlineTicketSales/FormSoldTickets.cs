using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTicketSales
{
    public partial class FormSoldTickets : Form
    {
        public Flight flight;
        public FormSoldTickets(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            labelFlightInfo.Text = flight.ToString();
            UpdateTicketsList();
        }
        private void UpdateTicketsList()
        {
            listBoxTickets.Items.Clear();
            foreach (var ticket in flight.SoldTickets)
            {
                listBoxTickets.Items.Add(ticket.ToString());
            }
            labelTotalPassengers.Text = $"Всего пассажиров: {flight.SoldTickets.Count}";
        }
        private void FormSoldTickets_Load(object sender, EventArgs e)
        {

        }
    }
}
