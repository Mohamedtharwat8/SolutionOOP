using OppAssignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_04
{
    public sealed class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; }

        public VIPTicket(string movieName, decimal price, bool loungeAccess, decimal serviceFee)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            ServiceFee = serviceFee;
        }

        public override string ToString()
        {
            string lounge = LoungeAccess ? "Yes" : "No";
            return $"{base.ToString()} | Lounge: {lounge} | Service Fee: {ServiceFee} EGP";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        }
    }
}
