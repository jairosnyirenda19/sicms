using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class HarvestDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static HarvestDatabaseController HarvestDatabase = null;
        public HarvestDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Harvest>().Wait();
        }

        public static HarvestDatabaseController HarvestDatabaseInstance(string x)
        {
            if (HarvestDatabase == null)
                HarvestDatabase = new HarvestDatabaseController(x);
            return HarvestDatabase;
        }

        public Task<List<Harvest>> GetItemsAsync()
        {
            return database.Table<Harvest>().ToListAsync();
        }

        public Task<List<Harvest>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Harvest>(Query);
        }

        public Task<Harvest> GetItemAsync(int id)
        {
            return database.Table<Harvest>().Where(i => i.harvest_id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Harvest item) 
        {
            if (item.harvest_id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(Harvest item)
        {
            return database.DeleteAsync(item);
        }
    }
}