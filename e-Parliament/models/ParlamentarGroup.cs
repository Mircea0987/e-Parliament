using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class ParlamentarGroup
    {
        [Key]
        [Column("parlamentar_group_id")]
        public int Id { get; set; }

        [Column("parlamentar_group_name")]
        public string ParlamentarGroupName { get; set; } = "";

        //navigation
        List<ParlamentarGroupMembers> parlamentarGroupMember { get; set; } 
    }
}
