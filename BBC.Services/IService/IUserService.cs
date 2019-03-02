using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BBC.Services.IService
{
    public interface IUserService
    {
        Task<bool> Subscribe();
    }
}
