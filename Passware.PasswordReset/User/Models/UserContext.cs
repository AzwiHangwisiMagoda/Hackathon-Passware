using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Entities;

namespace User.Models
{
    public class UserContext : DbContext
    {
        //public UserContext(DbContextOptions<UserContext> options)
        //    : base(options) { }

        //public DbSet<Users> Users { get; set; }

        protected readonly IConfiguration Configuration;

        public UserContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString(""));
        }

        public DbSet<Users> Users { get; set; }
    }
}
