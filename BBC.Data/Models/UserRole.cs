using System;
using System.Collections.Generic;
using System.Text;

namespace BBC.Data.Models
{
    public class UserRole
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
