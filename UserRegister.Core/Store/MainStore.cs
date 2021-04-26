using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using UserRegister.Core.Interface;
using UserRegister.Core.Entities;

namespace UserRegister.Core.Store
{
  public class MainStore : IMainStore
  {
    private IEnumerable<User> _store;

    public MainStore() {
      // Crea 10 registros dummy para consultar
      this._store = Enumerable.Range(1, 10).Select(x => new User
        {
            Id = x,
            UserId = $"User-{x}",
            Name = $"UserName-{x}",
            LastName = $"UserLastName-{x}",
            PhotoURL = "https://via.placeholder.com/150",
            Data = "test"
        });
    }

    public IEnumerable<User> getStore()
    {
      return this._store;
    }

    public IEnumerable<User> updateStore(IEnumerable<User> newData)
    {
      this._store = newData;
      return this._store;
    }
  };
}
