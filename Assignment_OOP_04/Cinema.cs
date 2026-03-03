using OppAssignment1;
using Assignment_OOP_04;

namespace Assignment_OOP_04
{


    public class Cinema
    {
        public string CinemaName { get; set; }

        // Composition: Cinema owns the projector
        private Projector _projector;
        private Ticket[] _tickets;
        private int _ticketCount;

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            _projector = new Projector(); // Projector created inside the Cinema
            _tickets = new Ticket[20];    // Holds up to 20 tickets
            _ticketCount = 0;
        }

        public void AddTicket(Ticket t)
        {
            if (_ticketCount < _tickets.Length)
            {
                _tickets[_ticketCount] = t;
                _ticketCount++;
            }
            else
            {
                Console.WriteLine("Cinema is full! Cannot add more tickets.");
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========");
            for (int i = 0; i < _ticketCount; i++)
            {
                _tickets[i].PrintTicket();
            }
            Console.WriteLine();
        }

        public void OpenCinema()
        {
            Console.WriteLine("\n========== Cinema Opened ==========");
            _projector.Start();
        }

        public void CloseCinema()
        {
            _projector.Stop();
            Console.WriteLine("========== Cinema Closed ==========\n");
        }


    }

}
