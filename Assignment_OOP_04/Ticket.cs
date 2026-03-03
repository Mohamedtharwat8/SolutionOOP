namespace OppAssignment1
{
    public abstract class Ticket
    {
        private static int _totalTickets = 0;
        private decimal _price;
        public static decimal TaxRate { get; set; } = 0.14m;
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
        public decimal PriceAfterTax => Price + (Price * TaxRate);

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


        public virtual void PrintTicket()
        {
            Console.WriteLine(
                $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:0.00} EGP"
            );
        }

        public void SetPrice(decimal price)
        {
            Console.WriteLine($"Setting price directly: {price}");
            Price = price;
        }


        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            decimal finalPrice = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {finalPrice}");
            Price = finalPrice;
        }
        public static int GetTotalTickets()
        {
            return _totalTickets;
        }
    }
}
