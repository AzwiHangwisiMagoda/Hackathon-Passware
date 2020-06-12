using Email.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email.Data
{
    public class EmailSeeder
    {
        public static void PopulateTestData(EmailContext dbContext)
        {
            dbContext.EmailList.Add(new ForgotPass
            {
                Email = "azwi.magoda@iress.com"
            });

            dbContext.EmailList.Add(new ForgotPass
            {
                Email = "katiso.koqo@iress.com"
            });

            dbContext.SaveChanges();
        }
    }
}
