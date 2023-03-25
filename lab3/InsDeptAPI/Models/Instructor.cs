using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsDeptAPI.Models
{
    public class Instructor
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "SSN must be in format xxx-xx-xxxx")]
        public string SSN { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone must be in format xxx-xxx-xxxx")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        // Navigation property
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        //public Department Department { get; set; }
    }
}
