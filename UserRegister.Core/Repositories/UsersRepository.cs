using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UserRegister.Core.Interface;
using System.Threading.Tasks;
using UserRegister.Core.Entities;

namespace UserRegister.Core.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private IEnumerable<User> _userData;
        public UsersRepository()
        {
            this._userData = Enumerable.Range(1, 10).Select(x => new User
            {
                Id = x,
                UserId = $"User-{x}",
                Name = $"UserName-{x}",
                LastName = $"UserLastName-{x}",
                PhotoURL = "https://via.placeholder.com/150",
                Data = "test"
            });
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            await Task.Delay(10);
            return _userData;
        }

        public async Task<User> GetUser(int id)
        {
            var user = _userData.Where(item => item.Id == id);
            await Task.Delay(10);
            return user.First();
        }

        public async Task<User> CreateUser(User user)
        {
            var id = this._userData.ToArray().Length;
            user.Id = id;
            this._userData.Append(user);
            await Task.Delay(10);
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            var updatedData = this._userData.Select(item =>
            {
                if (item.Id == user.Id)
                {
                    return user;
                }

                return item;
            });

            this._userData = updatedData;

            await Task.Delay(10);

            return user;
        }

        public async Task<IEnumerable<User>> DeleteUser(int id)
        {
            var updateData = this._userData.Where(item => item.Id != id);
            this._userData = updateData;

            await Task.Delay(10);

            return updateData;
        }
    }
}
