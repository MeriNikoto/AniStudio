using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AniStudio
{
    public partial class Project
    {
        public Project()
        {
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Type")]
        public int TypeId { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Finish Date")]
        public DateTime? FinishDate { get; set; }
        [Required(ErrorMessage = "This field can't be empty!")]
        [Display(Name = "Complitment")]
        public int? IsCompleted { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
