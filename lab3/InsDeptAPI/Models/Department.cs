using System.ComponentModel.DataAnnotations;

namespace InsDeptAPI.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        [StringLength(500)]
        public string Branches { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
