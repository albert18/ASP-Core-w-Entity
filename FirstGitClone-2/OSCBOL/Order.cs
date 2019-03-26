using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OSCBOL
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }
    }
}
