using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class ConfigurationurationDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static ConfigurationurationDatabaseController ConfigDatabase = null;
        public ConfigurationurationDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Configuration>().Wait();
        }

        public static ConfigurationurationDatabaseController ConfigDatabaseInstance(string x)
        {
            if (ConfigDatabase == null)
                ConfigDatabase = new ConfigurationurationDatabaseController(x);
            return ConfigDatabase;
        }

        public Task<List<Configuration>> GetItemsAsync()
        {
            return database.Table<Configuration>().ToListAsync();
        }

        public Task<List<Configuration>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Configuration>(Query);
        }

        public Task<Configuration> GetItemAsync(int id)
        {
            return database.Table<Configuration>().Where(i => i.config_id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Configuration item) 
        {
            if (item.config_id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(Configuration item)
        {
            return database.DeleteAsync(item);
        }

    }
}
