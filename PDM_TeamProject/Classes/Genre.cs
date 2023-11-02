using SQLite;

namespace PDM_TeamProject.Classes
{
    public class Genre
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
