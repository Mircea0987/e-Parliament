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
        [Column("user_id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; } = "";
        [Column("last_name")]
        public string LastName { get; set; } = "";
        [Column("email")]
        public string Email { get; set; } ="";
        [Column("hash_password")]
        public string HashPassword { get; set; } = "";
        [Column("date_of_birth")]
        public DateOnly DateOfBirth { get; set; }
        [Column("country")]
        public string Country { get; set; } = "";
        [Column("phone_number")]
        public string? PhoneNumber { get; set; }
        [Column("account_type_id")]
        public int AccountTypeId { get; set; } // foreign key to AccountType
        public AccountType AccountType { get; set; }// navigation property to AccountType


    }
}
