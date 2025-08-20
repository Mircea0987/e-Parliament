using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class Legislature
    {
        [Key]
        [Column("legislature_id")]
        public int Id { get; set; }

        [Column("legislature_start")]
        public DateTime StartDate { get; set; } = DateTime.MinValue;

        [Column("legislature_end")]
        public DateTime EndDate { get; set; } = DateTime.MinValue;

        List<Commission> commissions { get; set; }

    }
}
