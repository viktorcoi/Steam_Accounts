using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Accounts
{
    class Way
    {
        public int id { get; set; }

        private string way_steam;

        public string Way_Steam
        {
            get { return way_steam; }
            set { way_steam = value; }
        }

        public Way() { }
        
        public Way(string way_steam) {
            this.way_steam = way_steam;
        }
    }
}
