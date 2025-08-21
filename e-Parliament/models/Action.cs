using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class Action
    {
        [Key]
        [Column("action_id")]
        public int Id { get; set; }

        [Column("action_type")]
        public string Name { get; set; } = "";

        //navigation properties
        List<AccountTypeAction> AccountTypeActions { get; set; }
    }
}
