using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BBC.Data.Models
{
    public class User:IdentityUser<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
