using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class Parliamentarian
    {
        [Key]
        [Column("parliamentarian_id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; } = "";

        [Column("last_name")]
        public string LastName { get; set; } = "";

        [Column("id_room_type")]
        public int RoomTypeId { get; set; }

        //navigation 
        public RoomType RoomType { get; set; }

        List<ParliamentariansMember> parliamentariansMembers { get; set; }
    }
}
