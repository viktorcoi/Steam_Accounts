using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Accounts

{
    class Account
    {
        public int id { get; set; }

        private string name_acc;

        public string Name_Acc
        {
            get { return name_acc; }
            set { name_acc = value; }
        }

        public Account() { }

        public Account(string name_acc)
        {
            this.name_acc = name_acc;
        }
    }
}
