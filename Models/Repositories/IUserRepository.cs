using System.Collections.Generic;

namespace InventoryControl.Models.Repositories
{
    public interface IUserRepository
    {
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
    }
}
