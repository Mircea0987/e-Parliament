using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class Commission
    {

        [Key]
        [Column("commission_id")]
        public int Id { get; set; }

        [Column("commission_name")]
        public string CommissionName { get; set; } = "";

        [Column("legislature_id")]
        public int LegislatureId { get; set; }

        //navigation proprty to Legislature

        public Legislature IdLegislature { get; set; }

        //navigation to commission
        List<Meeting> meetings { get; set; }

        //navigation to commission_members

        List<CommissionMember> commissionMembers { get; set; }

        //navigation to parlaiment_members

       // List<ParlamentarCommission> parliamentMembers { get; set; }
    }
}
