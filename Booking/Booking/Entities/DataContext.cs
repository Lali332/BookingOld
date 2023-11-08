namespace Booking.Entities
{
    public class DataContext
    {
        public List<Orders> OrdersList { get; set; }
        public List<Renter> RentersList { get; set; }
        public List<Zimmer> ZimmersList { get; set; }
        public int CntOrders { get; set; }
        public int CntRenters { get; set; }
        public int CntZimmers { get; set; }
        public DataContext()
        {
            OrdersList = new List<Orders>();
            RentersList = new List<Renter>();
            ZimmersList = new List<Zimmer>();
            CntOrders = 1;
            CntRenters=1;
            CntZimmers=1;
        }

    }
}
