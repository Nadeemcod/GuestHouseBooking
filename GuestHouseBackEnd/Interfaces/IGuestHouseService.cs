using GuestHouseBackEnd.Models.Entities;

namespace GuestHouseBackEnd.Interfaces
{
    public interface IGuestHouseService
    {
        Task<IEnumerable<GuestHouse>> GetAllGuestHousesAsync();
        Task<IEnumerable<Room>> GetRoomsByGuestHouseIdAsync(int guestHouseId);
        Task<IEnumerable<Bed>> GetAvailableBedsByRoomIdAsync(int roomId);
    }
}
