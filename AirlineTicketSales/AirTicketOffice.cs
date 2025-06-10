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
                listBoxAvailableFlights.Items.Add(flight);
            }
        }
        private void listBoxAvailableFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddFlight_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableFlights.SelectedItem is Flight selectedFlight)
            {
                if (!listBoxSelectedFlights.Items.Contains(selectedFlight))
                {
                    listBoxSelectedFlights.Items.Add(selectedFlight);

                    var passengerForm = new FormPassanger(selectedFlight);
                    var result = passengerForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Рейс уже добавлен в выбранные.", "Информация", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Выберите рейс из списка слева.", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void buttonShowSoldTickets_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonShowSoldTickets_Click_1(object sender, EventArgs e)
        {
            if (listBoxSelectedFlights.SelectedItem is Flight selectedFlight)
            {
                var soldTicketsForm = new FormSoldTickets(selectedFlight);
                soldTicketsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите рейс из правого списка.", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
