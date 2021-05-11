using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fitness.Models
{
    public partial class Workout
    {
        public Workout()
        {
            OrderItems = new HashSet<OrderItems>();
            Schedule = new HashSet<Schedule>();
        }

        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [Range(0, 99)]
        public int Duration { get; set; }
        [Required]
        [Range(0, 9999.99)]
        public double Price { get; set; }
        [Required]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
