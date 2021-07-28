using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class User
    {
        //public int Id { get; set; }
        public string Unsername { get; set; }
        public string PassWort { get; set; }
        public int USD { get; set; }
        public int BankNumber { get; set; }

        User Us = new User();

        List<User> UserList = new List<User>();
    }
}
