using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set;}
        [Column("name")]
        public required string Name {get; set;}
        [Column("email")]
        public required string Email {get; set;}
        [Column("password")]
        public required string Password {get; set;}
        [Column("id_rol")]
        public int IdRol {get; set;}
        [ForeignKey("IdRol")]
        public Rol? Rol{get; set;}
    }
}