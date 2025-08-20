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
        [Column("id_parlamentar")]
        public int Id { get; set; }

        [Column("id_commission_members")]

        public int IdCommissionMembers { get;set; }

        //navigation property

        public CommissionMember commissionMember { get; set; }

        public Parliamentarian parliamentarian { get; set; }

    }
}
