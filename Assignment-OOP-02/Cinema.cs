using Assignment_OOP_02;

namespace Assignment_OOP_02
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        // Indexer with validation as required
        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < tickets.Length)
                    return tickets[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < tickets.Length)
                    tickets[index] = value;
                // else do nothing
            }
        }

        public Ticket GetMovieByName(string movieName)
        {
            foreach (var t in tickets)
            {
                if (t != null && t.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                    return t;
            }
            return null;
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
    }
}
