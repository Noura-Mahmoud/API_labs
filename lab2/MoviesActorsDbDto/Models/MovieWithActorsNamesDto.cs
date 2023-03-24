namespace MoviesActorsDbDto.Models
{
    public class MovieWithActorsNamesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public double Rate { get; set; }
        public string Producer { get; set; }
        public List<string> Actors { get; set; } = new List<string>();
    }
}
