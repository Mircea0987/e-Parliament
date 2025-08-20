using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class MeetingAtendace
    {
        [Key]
        [Column("meeting_attendance_id")]
        public int Id { get; set; }

        [Column("attendence_status")]
        public bool Status { get; set; } = false;

        [Column("parlamentar_id")]
        public int parlamentar_id { get; set; }

        //FK to meeting_id

        [Column("meeting_id")]
        public int MeetingId { get; set; }

        //Navigation property to Meeting
        public Meeting Meeting { get; set; }
    }

}
