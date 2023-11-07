using Microsoft.EntityFrameworkCore;

namespace ORMAndEF
{
    public class MovieReviewContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UMKUSS3\\FARRUKHSQL;Initial Catalog=YourDatabaseName;Integrated Security=True;TrustServerCertificate=true\r\n");
        }
    }
}
