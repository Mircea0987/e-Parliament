using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class CommissionMember
    {
        //M - M 
        [Key]
        [Column("commission_member_id")]
        public int Id { get; set; }

        [Column("role")]
        public string Role { get; set; } = "";

        [Column("parliament_member_id")]
        public int ParliamentMemberId { get; set; } // foreign key to ParliamentMember

        [Column("id_commission")]
        public int CommissionId { get; set; } // foreign key to Commission

        [Column("date_start")]
        public DateTime DateStart { get; set; }

        [Column("date_end")]
        public DateTime? DateEnd { get; set; } 

        //navigation
        List<ParlamentarGroupMembers> ParlamentarGroupMembers { get; set; }
        public Commission Commission { get; set; } 
        List<ParliamentariansMember> parliamentariansMembers { get; set; }


    }
}
    