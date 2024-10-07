using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date_order")]
        public DateOnly DateOrder { get; set; }
        [Column("total_products")]
        public int TotalProducts { get; set; }
        [Column("total_bill")]
        public double TotalBill { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("order_state_id")]
        public int OrderStateId { get; set; }
        [ForeignKey("CustomerId")]
        public Order order { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
        [ForeignKey("OrderStateId")]
        public OrderState orderState { get; set; }
    }
}