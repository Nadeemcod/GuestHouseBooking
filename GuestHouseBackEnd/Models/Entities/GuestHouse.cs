namespace GuestHouseBackEnd.Models.Entities
{
    public class GuestHouse
    {
        public int Id { get; set; }

        //public int GuestHouseId { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Room> Rooms { get; set; }


    }
}
