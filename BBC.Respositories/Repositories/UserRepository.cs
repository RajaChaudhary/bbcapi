using System;
using System.Collections.Generic;
using System.Text;
using BBC.Data;
using BBC.Data.Models;
using BBC.Respositories.IRepositories;

namespace BBC.Respositories.Repositories
{
    public class UserRepository:IUserRepository
    {
        public UserRepository(BBCDbContext context) 
        {
        }
    }
}
