using OppAssignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03
{
    public sealed class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; } = 50m;

        public VIPTicket(string movieName, decimal price, bool loungeAccess)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            string lounge = LoungeAccess ? "Yes" : "No";
            return $"{base.ToString()} | Lounge: {lounge} | Service Fee: {ServiceFee} EGP";
        }
    }
}
