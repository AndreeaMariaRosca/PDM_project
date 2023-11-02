using SQLite;

namespace PDM_TeamProject.Classes
{
    internal class Utils
    {
        public static void CheckDatabaseConnection(SQLiteConnection connection)
        {
            if (connection == null) throw new("No database connection.");
        }
    }
}
