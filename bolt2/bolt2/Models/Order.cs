using System;
using System.Collections.Generic;

#nullable disable

namespace bolt2.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public static int customerId { get; internal set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public DateTime CompletedAt { get; internal set; }
    }
}
