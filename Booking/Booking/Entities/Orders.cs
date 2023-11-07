namespace Booking.Entities
{
    public class Orders
    {
        public int codeOrder { get; set; }
        public int codeZimmer { get; set; }
        public string? tenantName { get; set; }
        public string? tenantPhone { get; set; }
        public DateOnly orderDate { get; set; }
        public DateOnly arrivalDate { get; set; }
        public DateOnly departureDate { get; set; }

    }
}
