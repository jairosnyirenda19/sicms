using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class MobileServiceDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static MobileServiceDatabaseController BankServiceDatabase = null;
        public MobileServiceDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<MobileService>().Wait();
        }

        public static MobileServiceDatabaseController MobileServiceDatabaseInstance(string x)
        {
            if (BankServiceDatabase == null)
                BankServiceDatabase = new MobileServiceDatabaseController(x);
            return BankServiceDatabase;
        }


        public Task<List<MobileService>> GetItemsAsync()
        {
            return database.Table<MobileService>().ToListAsync();
        }

        public Task<List<MobileService>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<MobileService>(Query);
        }

        public Task<MobileService> GetItemAsync(int id)
        {
            return database.Table<MobileService>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(MobileService item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(MobileService item)
        {
            return database.DeleteAsync(item);
        }
    }
}