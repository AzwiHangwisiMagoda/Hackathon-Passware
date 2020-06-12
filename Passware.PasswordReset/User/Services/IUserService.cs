using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Entities;

namespace User.Services
{
    public interface IUserService
    {
        void Update(UserEntity user, string password);
        UserEntity GetUserByUsername(string username);
    }
}
