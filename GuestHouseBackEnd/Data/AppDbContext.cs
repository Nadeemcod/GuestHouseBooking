using GuestHouseBackEnd.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GuestHouseBackEnd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<GuestHouse> GuestHouses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }

}
