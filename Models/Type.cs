using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AniStudio
{
    public partial class Type
    {
        public Type()
        {
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Type")]
        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
