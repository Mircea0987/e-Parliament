using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_Parliament.models
{
    internal class ParlamentarCommission
    {
        [Key]
        [Column("parlamentar_commission_id")]
        public int Id { get; set; }
        [Column("id_parlamentar")]
        public int idParlamentar { get; set; } // foreign key to Parlamentar

        [Column("id_commission")]
        public int IdCommission { get; set; } // foreign key to Commission

        [Column("role")]
        public string Role { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; } = DateTime.MinValue;

        [Column("end_date")]
        public DateTime? EndDate { get; set; } // Nullable to allow for ongoing memberships

        [Column("id_parlamentar_group")]
        public int id_parlamentar_group { get; set; }

        //navigation property
        public Commission commission { get; set; }
    }
}