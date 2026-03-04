using HomeTask01.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace HomeTask01.Models
{
    public class Major
    {
        [Required(ErrorMessage = "ID is required")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must contain at least 3 letters")]
        [NoNumber(ErrorMessage = "Name must contain only letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Credits is required")]
        [Range(1, 148, ErrorMessage = "Credits must be between 1 and 148")]
        public int Credits { get; set; }

        [Required(ErrorMessage = "CGPA is required")]
        [Range(0.0, 4.0, ErrorMessage = "CGPA must be between 0.0 and 4.0")]
        public double CGPA { get; set; }
    }
}
