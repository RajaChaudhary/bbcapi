using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BBC.Respositories.IRepositories
{
    public interface IUserRepository
    {
        Task<bool> Subscribe();
    }
}
