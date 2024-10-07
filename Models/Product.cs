using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public required string Name { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("price")]
        public required double Price { get; set; }
        [Column("stock")]
        public required int Stock { get; set; }
        [Column("id_category")]
        public int IdCategory { get; set; }
        [ForeignKey("IdCategory")]
        public Category? Category{ get; set; }
    }
}