using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesActorsDbDto.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public double Rate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Producer { get; set; }

        [InverseProperty("Movie")]
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
