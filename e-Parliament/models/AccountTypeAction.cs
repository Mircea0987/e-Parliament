    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace e_Parliament.models
    {
        [PrimaryKey(nameof(IdAccountType),nameof(IdAction))]
        internal class AccountTypeAction
        {
            [Column("account_type_id")]
            public int IdAccountType { get; set; }

            [Column("action_id")]
            public int IdAction { get; set; }

            //navigation properties
            [ForeignKey(nameof(IdAccountType))]

            public AccountType accountType { get; set; }
            [ForeignKey(nameof(IdAction))]

            public Action Action { get; set; }
        }
    }
