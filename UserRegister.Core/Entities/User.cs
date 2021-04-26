using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegister.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhotoURL { get; set; }
        public string Data { get; set; }
    }
}
