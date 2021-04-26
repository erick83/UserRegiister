using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserRegister.Core.Entities;

namespace UserRegister.Core.Interface
{
    public interface IUsersRepository
    {
        
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task<IEnumerable<User>> DeleteUser(int id);
    }
}
