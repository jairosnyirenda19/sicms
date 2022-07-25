using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class SeedClassDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static SeedClassDatabaseController seedClassDatabase = null;
        public SeedClassDatabaseController(string db_path)
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<SeedClass>().Wait();
        }

        public static SeedClassDatabaseController seedClassDatabaseInstance(string x)
        {
            if (seedClassDatabase == null)
                seedClassDatabase = new SeedClassDatabaseController(x);
            return seedClassDatabase;
        }

        public Task<List<SeedClass>> GetItemsAsync()
        {
            return database.Table<SeedClass>().ToListAsync();
        }

        public Task<List<SeedClass>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<SeedClass>(Query);
        }

        public Task<SeedClass> GetItemAsync(int id)
        {
            return database.Table<SeedClass>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(SeedClass item)
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);
        }
        public Task<int> DeleteItemAsync(SeedClass item)
        {
            return database.DeleteAsync(item);
        }
    }
}