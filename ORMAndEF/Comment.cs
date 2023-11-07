using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMAndEF
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string Emotion { get; set; }
        public int Score { get; set; }
        public int? MovieId { get; set; }
        public Movie Movie { get; set; }
        public int? ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
