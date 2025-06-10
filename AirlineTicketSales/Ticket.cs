namespace AirlineTicketSales
{
    namespace AirlineTicketApp
    {
        public class Ticket
        {
            public string PassengerFirstName;
            public string PassengerLastName;
            public string Seat;
            public Ticket(string firstName, string lastName, string seat)
            {
                PassengerFirstName = firstName;
                PassengerLastName = lastName;
                Seat = seat;
            }

            public override string ToString()
            {
                return $"{PassengerFirstName} {PassengerLastName}, место: {Seat}";
            }
        }
    }

}
