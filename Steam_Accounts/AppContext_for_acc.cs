using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Steam_Accounts 
{
    class AppContext_for_acc : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public AppContext_for_acc() : base("DefaultConnection1") { }
    }
}

