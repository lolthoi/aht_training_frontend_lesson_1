using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fitness.Models
{
    public partial class Category
    {
        public Category()
        {
            Workout = new HashSet<Workout>();
        }

        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$")]
        public string Name { get; set; }

        public virtual ICollection<Workout> Workout { get; set; }
    }
}
