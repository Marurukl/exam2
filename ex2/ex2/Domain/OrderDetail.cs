using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Domain
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }

    public class OrderDetailsConfiguration : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailsConfiguration()
        {
            Property(p => p.OrderId).IsRequired();
            Property(p => p.ProductId).IsRequired();
            Property(p => p.UnitPrice).IsRequired();
            Property(p => p.Quantity).IsRequired();
            Property(p => p.Discount).IsRequired();
        }
    }
}
