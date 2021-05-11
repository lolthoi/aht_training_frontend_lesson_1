using System;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fitness.Models
{
    public partial class Schedule
    {
        public Guid Id { get; set; }
        [Required]
        public Guid WId { get; set; }
        public Guid ExId { get; set; }
        [Required]
        public int DId { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        [Range(0, 20)]
        public int Repeats { get; set; }
        [Required]
        [Range(0, 10)]
        public int Sets { get; set; }

        public virtual Day D { get; set; }
        public virtual Exercise Ex { get; set; }
        public virtual Workout W { get; set; }
    }
}
