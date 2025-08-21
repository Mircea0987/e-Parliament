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
    [PrimaryKey(nameof(Id),nameof(IdCommissionMembers))]
    internal class ParliamentariansMember
    {
        [Column("parliamentarian_id")]
        public int Id { get; set; }

        [Column("commission_members_id")]
        public int IdCommissionMembers { get;set; }

        //navigation property

        [ForeignKey(nameof(IdCommissionMembers))]
        public CommissionMember CommissionMember { get; set; }

        [ForeignKey(nameof(Id))]
        public Parliamentarian Parliamentarian { get; set; }


    }
}
