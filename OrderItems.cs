using System;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fitness.Models
{
    public partial class OrderItems
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ItemId { get; set; }
        public double Price { get; set; }

        public virtual Workout Item { get; set; }
        public virtual Orders Order { get; set; }
    }
}
