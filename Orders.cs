using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fitness.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public Guid Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public Guid Uid { get; set; }

        public virtual Users U { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
