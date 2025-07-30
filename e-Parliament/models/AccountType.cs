using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class AccountType
    {
        public int id;
        public int Id { get; set; }
        public string? TypeName { get; set; }
        public string Actions { get; set; }
        public List<Users> Users { get; set; } 

    }
}
