using OppAssignment1;

namespace Assignment_OOP_04
{
    internal static class BookingHelper
    {
        private static int bookingCounter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5)
                total *= 0.9;
            return total;
        }

        public static string GenerateBookingReference()
        {
            bookingCounter++;
            return $"BK-{bookingCounter}";
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("========== Process Single Ticket ==========");
            t.PrintTicket(); // polymorphism here
        }
    }
}
