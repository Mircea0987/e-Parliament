using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.models
{
    internal class Users
    {
        [Key]
        public int Id { get; set; }
        [Column("firstName")]
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } ="";
        public string HashPassword { get; set; } = "";
        public DateOnly DateOfBirth { get; set; }
        public string Country { get; set; }
        public string? PhoneNumber { get; set; }
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }


    }
}
