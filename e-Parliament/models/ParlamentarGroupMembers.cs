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
        [Column("id_parlamentar_group")]
        public int Id { get; set; }

        [Column("id_members")]

        public int IdMembers { get; set; }

        public int Id_legislature { get; set; }

        // navigation properties

        public CommissionMember CommissionMember { get; set; }

        public ParlamentarGroup Members { get; set; }
    }
}
