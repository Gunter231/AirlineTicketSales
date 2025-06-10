using AirlineTicketSales.AirlineTicketApp;
using System.Collections.Generic;

namespace AirlineTicketSales
{
    public class Flight
    {
        public string Name;
        public string Date;
        public string Time;
        public List<Ticket> SoldTickets;
        public Flight(string name, string date, string time)
        {
            Name = name;
            Date = date;
            Time = time;
        }
        public override string ToString()
        {
            return $"{Name} - {Date} {Time}";
        }
        public bool IsSeatTaken(string seat)
        {
            foreach (var ticket in SoldTickets)
            {
                if (ticket.Seat == seat)
                    return true;
            }
            return false;
        }
        public void AddTicket(Ticket ticket)
        {
            SoldTickets.Add(ticket);
        }
    }

}
