using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMvc.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string? Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "{0} is mandatory")]
        [DataType(DataType.DateTime, ErrorMessage = "{0} format is invalid")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [EmailAddress(ErrorMessage = "{0} format field is invalid")]
        public string? Email { get; set; }

        [Display(Name = "Confirm Email")]
        [Required(ErrorMessage = "{0} is mandatory")]
        [Compare("Email", ErrorMessage = "{1} and {0} must be match")]
        [NotMapped]
        public string? ConfirmEmail { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [Range(1, 5, ErrorMessage = "{0} must be between {1} and {2}")]
        public int Avaliation { get; set; }
        public bool Active { get; set; }
    }
}
