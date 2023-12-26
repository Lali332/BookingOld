namespace Booking.Core.Entities
{
    public class Zimmer
    {
        public int zimmerId { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public int renterCode { get; set; }
        public int price { get; set; }
        public string description { get; set; }
      
    }
}
