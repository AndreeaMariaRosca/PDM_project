using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDM_TeamProject.Classes
{
    public class Serie
    {
        [PrimaryKey]
        public int Id { get; set; }
        [NotNull]
        public string Title { get; set; }
        [NotNull]
        public int[] GenreId { get; set; }
        public float? UserRating { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Description { get; set; }
        public int DirectorId { get; set; }
        public int WriterId { get; set; }
        public int[] ActorId { get; set; }

    }
}
