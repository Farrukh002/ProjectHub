using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMAndEF
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public string Gender { get; set; }
        public string CountryOfOrigin { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
