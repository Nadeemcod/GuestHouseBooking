using GuestHouseBackEnd.Data;
using GuestHouseBackEnd.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuestHouseBackEnd.Services
{
    public class AdminService
    {
        private readonly AppDbContext _context;

        public AdminService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _context.Bookings.Include(b => b.User).Include(b => b.Bed).ToListAsync();
        }

        public async Task ApproveBookingAsync(int bookingId)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking != null) booking.Status = "Approved";
            await _context.SaveChangesAsync();
        }

        public async Task RejectBookingAsync(int bookingId)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking != null) booking.Status = "Rejected";
            await _context.SaveChangesAsync();
        }
    }
}