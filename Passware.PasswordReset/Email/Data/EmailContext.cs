using Email.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email
{
    public class EmailContext : DbContext
    {
        public EmailContext(DbContextOptions<EmailContext> options)
            : base(options)
        {
        }

        public DbSet<ForgotPass> EmailList { get; set; }
    }
}
