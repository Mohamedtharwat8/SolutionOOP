using OppAssignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_04
{
    public sealed class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber)
            : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Seat: {SeatNumber}";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Seat: {SeatNumber}");
        }
    }
}
