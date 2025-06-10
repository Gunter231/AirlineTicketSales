using AirlineTicketSales.AirlineTicketApp;
using System;
using System.Windows.Forms;

namespace AirlineTicketSales
{
    public partial class FormPassanger : Form
    {
        private Flight flight;
        public FormPassanger(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            labelFlightInfo.Text = flight.ToString();
        }

        private void FormPassanger_Load(object sender, EventArgs e)
        {

        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string seat = textBoxSeat.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(seat))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (flight.IsSeatTaken(seat))
            {
                MessageBox.Show("Это место уже занято. Выберите другое.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var ticket = new Ticket(firstName, lastName, seat);
            flight.AddTicket(ticket);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
