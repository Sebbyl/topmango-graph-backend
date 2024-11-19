namespace graph_backend.Models
{
    public class AreaChartCustomer
    {
        public int Id { get; set; }
        public bool HasLoyalty { get; set; }
        public double Price { get; set; }
        public required string Date { get; set; }
    }

    public class BarChartCustomer
    {
        public int Id { get; set; }
        public bool InStore { get; set; }
        public double TicketPrice { get; set; }
        public string Date { get; set; }
    }

    public class PieChartCustomer
    {
        public double AllCustomersAverageTicketSize { get; set; }
        public double LoyaltyAverageTicketSize { get; set; }
    }

    public class Chart<T>
    {
        public int ChartId { get; set; }
        public List<T> Customers { get; set; }
    }

}
