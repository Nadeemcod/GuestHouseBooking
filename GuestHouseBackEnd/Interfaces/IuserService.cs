using GuestHouseBackEnd.Models.Entities;

namespace GuestHouseBackEnd.Interfaces
{
    public interface IuserService
    {
        Task<User?> AuthenticateAsync(string email, string password);
        Task<bool> RegisterAsync(User user);
        Task<User?> GetByIdAsync(int id);
    }
}
