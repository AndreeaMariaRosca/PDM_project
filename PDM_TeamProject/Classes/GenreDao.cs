using SQLite;

namespace PDM_TeamProject.Classes
{
    public class GenreDao
    {
        SQLiteConnection Connection;

        public GenreDao(SQLiteConnection connection)
        {
            Connection = connection;
        }

        public int InsertOrUpdateGenres(List<Genre> genres)
        {
            // do we need this?
            return 0;
        }

        public Genre GetGenre(int id)
        {
            Utils.CheckDatabaseConnection(Connection);
            return Connection.Table<Genre>().Where(genre => genre.Id == id).FirstOrDefault();
        }
    }
}
