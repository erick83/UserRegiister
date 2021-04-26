using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserRegister.Core.Entities;

namespace UserRegister.Core.Interface
{
    public interface IMainStore
    {
        IEnumerable<User> getStore();
        IEnumerable<User> updateStore(IEnumerable<User> newData);
    }
}
