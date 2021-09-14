using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Steam_Accounts
{
    class AppContext_for_way : DbContext
    {
        public DbSet<Way> Ways { get; set; }

        public AppContext_for_way() : base("DefaultConnection") { }
    }
}
