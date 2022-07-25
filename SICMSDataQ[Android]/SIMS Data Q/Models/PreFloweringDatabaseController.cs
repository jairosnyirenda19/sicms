using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class PreFloweringDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static PreFloweringDatabaseController PreFloweringDatabase = null;
        public PreFloweringDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<PreFlowering>().Wait();
        }

        public static PreFloweringDatabaseController PreFloweringDatabaseInstance(string x)
        {
            if (PreFloweringDatabase == null)
                PreFloweringDatabase = new PreFloweringDatabaseController(x);
            return PreFloweringDatabase;
        }

        public Task<List<PreFlowering>> GetItemsAsync()
        {
            return database.Table<PreFlowering>().ToListAsync();
        }

        public Task<List<PreFlowering>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<PreFlowering>(Query);
        }

        public Task<PreFlowering> GetItemAsync(int id)
        {
            return database.Table<PreFlowering>().Where(i => i.preflowering_id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(PreFlowering item) 
        {
            if (item.preflowering_id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(PreFlowering item)
        {
            return database.DeleteAsync(item);
        }
    }
}