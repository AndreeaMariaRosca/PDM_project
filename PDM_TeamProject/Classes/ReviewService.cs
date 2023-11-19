using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PDM_TeamProject.Classes
{
    public class ReviewService
    {
        public SQLiteAsyncConnection _dbConnection;

        private async Task SetupDatabase()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TvSeries.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Review>();
            }
        }

        public async Task<int> AddReview(Review review)
        {
            await SetupDatabase();
            return await _dbConnection.InsertAsync(review);

        }

        public async Task<int> DeleteReview(Review review)
        {
            await SetupDatabase();
            return await _dbConnection.DeleteAsync(review);
        }

        public async Task<List<Review>> GetEmployeesList()
        {
            await SetupDatabase();
            var reviewList = await _dbConnection.Table<Review>().ToListAsync();
            return reviewList;
        }

        public async Task<int> UpdateReview(Review review)
        {
            await SetupDatabase();
            return await _dbConnection.UpdateAsync(review);
        }

    }
}
