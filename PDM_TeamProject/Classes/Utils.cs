using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
