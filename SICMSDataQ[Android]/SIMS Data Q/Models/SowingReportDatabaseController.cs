using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class SowingReportDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static SowingReportDatabaseController SowingReportDatabase = null;
        public SowingReportDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<SowingReport>().Wait();
        }

        public static SowingReportDatabaseController SowingReportDatabaseInstance(string x) 
        {
            if (SowingReportDatabase == null)
                SowingReportDatabase = new SowingReportDatabaseController(x);
            return SowingReportDatabase;
        }

        public Task<List<SowingReport>> GetItemsAsync()
        {
            return database.Table<SowingReport>().ToListAsync();
        }

        public Task<List<SowingReport>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<SowingReport>(Query);
        }

        public Task<SowingReport> GetItemAsync(int id)
        {
            return database.Table<SowingReport>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(SowingReport item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(SowingReport item)
        {
            return database.DeleteAsync(item);
        }
    }
}