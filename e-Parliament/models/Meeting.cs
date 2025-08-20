using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class Meeting
    {
        [Key]
        [Column("meeting_id")]
        public int Id { get; set; }

        [Column("meeting_date")]
        public DateTime MeetingDate { get; set; } = DateTime.MinValue;

        [Column("meeting_subject")]
        public string Subject { get; set; } = "";

        [Column("meeting_location")]
        public string Location { get; set; } = "";

        // FK to commision
        [Column("commission_id")]
        public int CommissionId { get; set; }

        // navigation property to meeting attendees
        List<MeetingAtendace> meetingAtendaces { get; set; }

        List<MeetingDocument> meetingDocuments { get; set; }

    }
}
