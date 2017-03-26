using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Call_Logger.Models
{
    public class CallDBContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}