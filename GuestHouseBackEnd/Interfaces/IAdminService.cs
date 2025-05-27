using GuestHouseBackEnd.Models.Entities;
using System.Threading.Tasks;

namespace GuestHouseBackEnd.Interfaces
{
    public interface IAdminService
    {
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task ApproveBookingAsync(int bookingId);
        Task RejectBookingAsync(int bookingId);
    }
}
