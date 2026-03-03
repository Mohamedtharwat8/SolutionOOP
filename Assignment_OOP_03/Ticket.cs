namespace OppAssignment1
{  
    public abstract class Ticket
    {
        private static int _totalTickets = 0;
        private decimal _price;

        // Auto-incremented, read-only TicketId
        public int TicketId { get; }

        public string MovieName { get; set; }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new ArgumentException("Price must be greater than zero.");
            }
        }
        public decimal PriceAfterTax => Price * 1.14m;

        // Constructor
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;

            _totalTickets++;
            TicketId = _totalTickets;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }

        public static int GetTotalTickets()
        {
            return _totalTickets;
        }
    }
}
