using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class RoomType
    {
        [Key]
        [Column("room_type_id")]
        public int Id { get; set; }

        [Column("room_type_name")]
        public string RoomTypeName { get; set; } = "";

        //navigation
        List<Parliamentarian> parliamentarians { get; set; }
    }
}
