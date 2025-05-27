using GuestHouseBackEnd.Dto;
using GuestHouseBackEnd.Models.Entities;

namespace GuestHouseBackEnd.Interfaces
{
    public interface IBookingService
    {
        Task<string> CreateBookingAsync(int userId, BookingRequestDto dto);
        Task<IEnumerable<Booking>> GetBookingsByUserAsync(int userId);
    }
}
