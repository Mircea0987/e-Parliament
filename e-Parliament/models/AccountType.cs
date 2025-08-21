using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Parliament.enums;

namespace e_Parliament.models
{
    internal class AccountType
    {
        [Key]
        [Column("account_type_id")]
        public int Id { get; set; }
        [Column("type_name")]
        public TypeNameEnum TypeName { get; set; }

        //navigation properties
        public List<Users> Users { get; set; }

        public List<AccountTypeAction> AccountTypeActions { get; set; }


    }
}
