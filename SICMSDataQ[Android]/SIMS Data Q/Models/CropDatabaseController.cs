using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class CropDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static CropDatabaseController CropDatabase = null;
        public CropDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Crop>().Wait();
        }

        public static CropDatabaseController CropDatabaseInstance(string x)
        {
            if (CropDatabase == null)
                CropDatabase = new CropDatabaseController(x);
            return CropDatabase;
        }

        public Task<List<Crop>> GetItemsAsync()
        {
            return database.Table<Crop>().ToListAsync();
        }

        public Task<List<Crop>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Crop>(Query);
        }

        public Task<Crop> GetItemAsync(int id)
        {
            return database.Table<Crop>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Crop item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(Crop item)
        {
            return database.DeleteAsync(item);
        }
    }
}