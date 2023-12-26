namespace Booking.Core.Entities
{
    public class Orders
    {
        public int ordersId { get; set; }
        public int codeZimmer { get; set; }
        public string? tenantName { get; set; }
        public string? tenantPhone { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public DateTime departureDate { get; set; }

    }
}



