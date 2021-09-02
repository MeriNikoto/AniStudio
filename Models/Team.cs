using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AniStudio
{
    public partial class Team
    {
        public Team()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Project")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        public string Task { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
