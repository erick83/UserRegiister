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
        private IMainStore _userData;
        public UsersRepository(IMainStore store)
        {
            this._userData = store;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            await Task.Delay(10);
            return _userData.getStore();
        }

        public async Task<User> GetUser(int id)
        {
            var user = _userData.getStore().Where(item => item.Id == id);
            await Task.Delay(10);
            return user.First();
        }

        public async Task<User> CreateUser(User user)
        {
            var id = this._userData.getStore().ToArray().Length;
            user.Id = id;
            this._userData.getStore().Append(user);
            await Task.Delay(10);
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            var updatedData = this._userData.getStore().Select(item =>
            {
                if (item.Id == user.Id)
                {
                    return user;
                }

                return item;
            });

            this._userData.updateStore(updatedData);

            await Task.Delay(10);

            return user;
        }

        public async Task<IEnumerable<User>> DeleteUser(int id)
        {
            var updatedData = this._userData.getStore().Where(item => item.Id != id);
            this._userData.updateStore(updatedData);

            await Task.Delay(10);

            return this._userData.getStore();
        }
    }
}
