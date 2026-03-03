using OppAssignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_04
{
    public sealed class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D)
            // If Is3D is true, increase price by 30 EGP before passing it to the base constructor
            : base(movieName, is3D ? price + 30m : price)
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            string threeD = Is3D ? "Yes" : "No";
            return $"{base.ToString()} | IMAX 3D: {threeD}";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
