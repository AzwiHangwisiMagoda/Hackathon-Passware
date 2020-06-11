using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passware.Email.Models
{
    public class PasswordReset
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
