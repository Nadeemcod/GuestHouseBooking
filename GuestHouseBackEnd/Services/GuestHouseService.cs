using GuestHouseBackEnd.Data;
using GuestHouseBackEnd.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuestHouseBackEnd.Services
{
    public class GuestHouseService
    {
        private readonly AppDbContext _context;

        public GuestHouseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GuestHouse>> GetAllGuestHousesAsync()
        {
            return await _context.GuestHouses.ToListAsync();
        }

        public async Task<IEnumerable<Room>> GetRoomsByGuestHouseIdAsync(int guestHouseId)
        {
            return await _context.Rooms.Where(r => r.GuestHouseId == guestHouseId).ToListAsync();
        }

        public async Task<IEnumerable<Bed>> GetAvailableBedsByRoomIdAsync(int roomId)
        {
            return await _context.Beds.Where(b => b.RoomId == roomId && b.IsAvaible).ToListAsync();
        }
    }
}
