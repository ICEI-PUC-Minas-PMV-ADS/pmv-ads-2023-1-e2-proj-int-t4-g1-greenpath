using System;
using GP23.Models;

namespace GP23.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<AppUser>> GetAllUsers();
        Task<AppUser> GetUserById(string id);
        bool Add(AppUser user);
        bool Update(AppUser user);
        bool Delete(AppUser user);
        bool Save();
    }
}

