namespace GuestHouseBackEnd.Models.Entities
{
    public class Room
    {

        public int Id { get; set; }

        public string RoomNo { get; set; }

        public int GuestHouseId { get; set; }

        public GuestHouse GuestHouse { get; set; }  

        public ICollection<Bed> Beds { get; set; }
    }
}
