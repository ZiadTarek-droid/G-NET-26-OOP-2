using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ticket
    {
        private string movieName;
        private double price;

        private static int ticketCounter = 0;

        public int TicketId { get; }

        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
            }
        }

        public TicketType Type { get; set; }

        public SeatLocation Seat { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public double PriceAfterTax
        {
            get { return price * 1.14; }
        }

        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;

            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }
    }
}
