namespace GuestHouseBackEnd.Models.Entities
{
    public class Bed
    {
        public int Id { get; set; }

        public int BedNo { get; set; }

        public bool IsAvaible { get; internal set; }

        public int RoomId { get; set; } 

        public Room Room { get; set; }  
    }
}
