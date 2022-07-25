using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class PaymentDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static PaymentDatabaseController PaymentDatabase = null;
        public PaymentDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Payment>().Wait();
        }
        public static PaymentDatabaseController PaymentDatabaseInstance(string x)
        {
            if (PaymentDatabase == null)
                PaymentDatabase = new PaymentDatabaseController(x);
            return PaymentDatabase;
        }

        public Task<List<Payment>> GetItemsAsync()
        {
            return database.Table<Payment>().ToListAsync();
        }

        public Task<List<Payment>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Payment>(Query);
        }

        public Task<Payment> GetItemAsync(int id)
        {
            return database.Table<Payment>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Payment item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(Payment item)
        {
            return database.DeleteAsync(item);
        }
    }
}