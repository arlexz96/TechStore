using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    [Table("order_products")]
    public class OrderProducts
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("quantity")]
        public int Quantity{ get; set; }
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("product_id")]
        public int ProductoId { get; set; }
        [ForeignKey("OrderId")]
        public Order order { get; set; }
        [ForeignKey("ProductoId")]
        public Product product { get; set; }
    }
}