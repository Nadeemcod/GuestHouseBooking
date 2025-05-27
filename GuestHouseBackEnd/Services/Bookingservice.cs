using GuestHouseBackEnd.Data;
using GuestHouseBackEnd.Dto;
using GuestHouseBackEnd.Interfaces;
using GuestHouseBackEnd.Models.Entities;
using Microsoft.EntityFrameworkCore;
//using GuestHouseBackEnd.Models.Entities;



namespace GuestHouseBackEnd.Services
{
    public class BookingService : IBookingService
    {
        private readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateBookingAsync(int user, BookingRequestDto dto)
        {
            var bed = await _context.Beds.FindAsync(dto.BedId);
            if (bed == null || !bed.IsAvaible)
                return "Bed is not available.";

            var booking = new Booking
            {
                BedId = dto.BedId,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Status = "Pending",
                User = user
            };

            bed.IsAvaible = false;
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return "Booking request submitted.";
        }

        public async Task<IEnumerable<Booking>> GetBookingsByUserAsync(int userId)
        {
            return await _context.Bookings
                .Where(b => b.UserId == userId)
                .Include(b => b.Bed)
                .ToListAsync();
        }
    }

}
