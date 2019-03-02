using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BBC.Respositories.IRepositories;
using BBC.Services.IService;

namespace BBC.Services.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
     

      public async  Task<bool> Subscribe()
        {
            throw new NotImplementedException();
        }
    }
}
