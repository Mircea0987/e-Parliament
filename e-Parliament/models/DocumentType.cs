using e_Parliament.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class DocumentType
    {
        [Key]
        [Column("document_type_id")]
        public int Id { get; set; }

        [Column("document_type")]
        public DocuemntTypeEnum documentType { get; set; }

        [Column("file_path")]
        public string filePath { get; set; }

        //Navigation property to MeetingDocument
        List<MeetingDocument> meetingDocuments { get; set; }

    }
}
