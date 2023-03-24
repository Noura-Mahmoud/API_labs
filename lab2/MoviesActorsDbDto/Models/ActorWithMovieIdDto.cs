namespace MoviesActorsDbDto.Models
{
    public class ActorWithMovieIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public int? MovieId { get; set; }
    }
}
