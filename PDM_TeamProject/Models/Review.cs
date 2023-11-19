using SQLite;

namespace PDM_TeamProject.Classes
{
    public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
    }
}
