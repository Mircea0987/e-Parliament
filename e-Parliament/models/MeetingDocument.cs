using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class MeetingDocument
    {
        [Key]
        [Column("meeting_document_id")]
        public int Id { get; set; }

        [Column("commission_id")]
        public int CommissionId { get; set; }

        [Column("meeting_id")]
        public int MeetingId { get;set; }

        [Column("document_name")]
        public string DocumentName { get; set; } = "";

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.MinValue;

        //file path?

        [Column("is_shared")]
        public bool IsShared { get; set; } = false;

        // FK
        [Column("document_type_id")]
        public int DocumentType { get; set; }

        // Navigation property
        public DocumentType DocumentTypeNavigation { get; set; }
        public Meeting Meeting { get; set; }

    }
}
