using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class PaymentMethodDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static PaymentMethodDatabaseController PaymentMethodDatabase = null;
        public PaymentMethodDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<PaymentMethod>().Wait();
        }

        public static PaymentMethodDatabaseController PaymentMethodDatabaseInstance(string x)
        {
            if (PaymentMethodDatabase == null)
                PaymentMethodDatabase = new PaymentMethodDatabaseController(x);
            return PaymentMethodDatabase;
        }

        public Task<List<PaymentMethod>> GetItemsAsync()
        {
            return database.Table<PaymentMethod>().ToListAsync();
        }

        public Task<List<PaymentMethod>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<PaymentMethod>(Query);
        }

        public Task<PaymentMethod> GetItemAsync(int id)
        {
            return database.Table<PaymentMethod>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(PaymentMethod item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(PaymentMethod item)
        {
            return database.DeleteAsync(item);
        }
    }
}