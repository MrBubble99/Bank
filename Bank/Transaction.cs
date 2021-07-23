using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Transaction
    {
        public string PayingUser { get; set; }
        public int AcountNoPU { get; set; }
        public string RecivingUser { get; set; }
        public int AcountNoRU { get; set; }
        public int TrasAmount { get; set; }
        public string RefTrans { get; set; }
        

    }

}
