namespace GuestHouseBackEnd.Models.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public int UserId { get; set; }

        // Navigation property - not required in POST body
        public User? User { get; set; }

        public int BedId { get; set; }

        // Navigation property - not required in POST body
        public Bed? Bed { get; set; }
    }
}
