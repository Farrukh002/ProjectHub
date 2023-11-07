namespace ORMAndEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MovieReviewContext())
            {
                var newMovie = new Movie
                {
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Genre = "Drama",
                    CountryOfOrigin = "United States",
                    Actors = new List<Actor>(), 
                    Comments = new List<Comment>()
                };

                var newActor = new Actor
                {
                    Name = "Tim Robbins",
                    YearOfBirth = 1958,
                    Gender = "Male",
                    CountryOfOrigin = "United States",
                    Movies = new List<Movie>(), // Initialize the Movies collection
                    Comments = new List<Comment>() // Initialize the Comments collection
                };

                var newComment = new Comment
                {
                    CommentText = "Great movie!",
                    Emotion = "Positive",
                    Score = 5
                };

                // Establish relationships
                newMovie.Actors.Add(newActor);
                newMovie.Comments.Add(newComment);

                newActor.Movies.Add(newMovie);
                newActor.Comments.Add(newComment);

                newComment.Movie = newMovie;
                newComment.Actor = newActor;

                // Add entities to the context
                context.Movies.Add(newMovie);
                context.Actors.Add(newActor);
                context.Comments.Add(newComment);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Data added to the database successfully.");
            }
        }
    }
}