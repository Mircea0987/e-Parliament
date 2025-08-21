using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    [PrimaryKey(nameof(Id), nameof(IdMembers))]
    internal class ParlamentarGroupMembers
    {
        [Column("parlamentar_group_id")]
        public int Id { get; set; }

        [Column("member_group_id")]

        public int IdMembers { get; set; }

        [Column("legislature_id")]
        public int Id_legislature { get; set; }

        // navigation properties

        [ForeignKey(nameof(IdMembers))]
        public CommissionMember CommissionMember { get; set; }

        [ForeignKey(nameof(Id))]

        public ParlamentarGroup Members { get; set; }
    }
}
