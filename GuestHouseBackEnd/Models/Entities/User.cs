

namespace GuestHouseBackEnd.Models.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }//admin or user?

        public static implicit operator User(int v)
        {
            throw new NotImplementedException();
        }


        //relation

        //public ICollection<Booking> Bookings { get; set; }

        //public static implicit operator User(int v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
