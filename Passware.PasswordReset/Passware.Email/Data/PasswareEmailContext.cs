using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Passware.Email.Models;

namespace Passware.Email.Data
{
    public class PasswareEmailContext : DbContext
    {
        public PasswareEmailContext (DbContextOptions<PasswareEmailContext> options)
            : base(options)
        {
        }

        public DbSet<Passware.Email.Models.PasswordReset> PasswordReset { get; set; }
    }
}
