using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AniStudio
{
    public partial class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Position")]
        public int PositionId { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Team")]
        public int TeamId { get; set; }

        public virtual Position Position { get; set; }
        public virtual Team Team { get; set; }
    }
}
