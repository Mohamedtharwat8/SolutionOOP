using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_02
{
    class Ticket
    {
        private static int ticketCounter = 0;
        private int ticketId;
        private string movieName;
        private double price;

        public string MovieName
        {
            get => movieName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    movieName = value;
                // else keep previous value by doing nothing
            }
        }

        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                // else keep previous value
            }
        }

        public double PriceAfterTax => Price * 1.14;

        public int TicketId => ticketId;

        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            // Defaults
            this.movieName = "Untitled Movie";
            this.price = 1; // Minimum
                            // Assigning with validation
            MovieName = movieName;
            Price = price;
            Type = type;
            Seat = seat;

            ticketCounter++;
            ticketId = ticketCounter;
        }

        public static int GetTotalTicketsSold() => ticketCounter;

        public override string ToString()
        {
            return $"Ticket: #{TicketId} | {MovieName} | {Type} | Seat: {Seat} | Price: {Price:0.00} EGP | After Tax: {PriceAfterTax:0.00} EGP";
        }
    }

}
