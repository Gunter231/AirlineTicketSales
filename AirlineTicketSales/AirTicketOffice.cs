using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AirlineTicketSales.AirTicketOffice;

namespace AirlineTicketSales
{

    public partial class AirTicketOffice : Form
    {
        private List<Flight> flights;

        public AirTicketOffice()
        {
            InitializeComponent();
            InitializeFlights();
            UpdateFlightList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeFlights()
        {
            flights = new List<Flight>
            {
                new Flight("Москва–Сочи", "15.06.2025", "10:00"),
                new Flight("Новосибирск–Санкт-Петербург", "16.06.2025", "12:30"),
                new Flight("Казань–Самара", "17.06.2025", "09:15"),
                new Flight("Владивосток–Москва", "18.06.2025", "14:45")
            };
        }

        private void UpdateFlightList()
        {
            listBoxAvailableFlights.Items.Clear();
            foreach (Flight flight in flights)
            {
                listBoxAvailableFlights.Items.Add(flight.Name + flight.Date + flight.Time);
            }
        }
        private void listBoxAvailableFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
    public class Flight
    {
        public string Name;
        public string Date;
        public string Time;
        public Flight(string name, string date, string time)
        {
            Name = name;
            Date = date;
            Time = time;
        }
    }

}
