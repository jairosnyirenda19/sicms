using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class BankServiceDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static BankServiceDatabaseController BankServiceDatabaseDatabase = null;
        public BankServiceDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<BankService>().Wait();
        }

        public static BankServiceDatabaseController BankServiceDatabaseInstance(string x)
        {
            if (BankServiceDatabaseDatabase == null)
                BankServiceDatabaseDatabase = new BankServiceDatabaseController(x);
            return BankServiceDatabaseDatabase;
        }

        public Task<List<BankService>> GetItemsAsync()
        {
            return database.Table<BankService>().ToListAsync();
        }

        public Task<List<BankService>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<BankService>(Query);
        }

        public Task<BankService> GetItemAsync(int id)
        {
            return database.Table<BankService>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(BankService item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(BankService item)
        {
            return database.DeleteAsync(item);
        }
    }
}