using System;
using System.Collections.Generic;

#nullable disable

namespace bolt2.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
