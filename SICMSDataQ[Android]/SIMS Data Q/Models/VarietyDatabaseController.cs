using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class VarietyDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static VarietyDatabaseController VarietyDatabase = null;
        public VarietyDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Variety>().Wait();
        }

        public static VarietyDatabaseController VarietyDatabaseInstance(string x)
        {
            if (VarietyDatabase == null)
                VarietyDatabase = new VarietyDatabaseController(x);
            return VarietyDatabase;
        }

        public Task<List<Variety>> GetItemsAsync()
        {
            return database.Table<Variety>().ToListAsync();
        }

        public Task<List<Variety>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Variety>(Query);
        }

        public Task<Variety> GetItemAsync(int id)
        {
            return database.Table<Variety>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Variety item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(Variety item)
        {
            return database.DeleteAsync(item);
        }
    }
}