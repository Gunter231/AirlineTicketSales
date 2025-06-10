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
    }
}
