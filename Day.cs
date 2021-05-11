using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace fitness.Models
{
    public partial class Day
    {
        public Day()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
