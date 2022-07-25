using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class FloweringDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static FloweringDatabaseController FloweringDatabase = null;
        public FloweringDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Flowering>().Wait();
        }

        public static FloweringDatabaseController FloweringDatabaseInstance(string x)
        {
            if (FloweringDatabase == null)
                FloweringDatabase = new FloweringDatabaseController(x);
            return FloweringDatabase;
        }

        public Task<List<Flowering>> GetItemsAsync()
        {
            return database.Table<Flowering>().ToListAsync();
        }

        public Task<List<Flowering>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Flowering>(Query);
        }

        public Task<Flowering> GetItemAsync(int id)
        {
            return database.Table<Flowering>().Where(i => i.flowering_id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Flowering item) 
        {
            if (item.flowering_id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(Flowering item)
        {
            return database.DeleteAsync(item);
        }
    }
}