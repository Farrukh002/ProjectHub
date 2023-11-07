namespace ORMAndEF
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string CountryOfOrigin { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
