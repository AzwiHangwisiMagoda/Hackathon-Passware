using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Entities;

namespace User.Services
{
    public interface IUserService
    {
        Users Authenticate(string username, string password);
        Users Create(Users user, string password);
    }
}
