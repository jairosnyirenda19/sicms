using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class ClientDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static ClientDatabaseController ClientDatabase = null;
        public ClientDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Client>().Wait();
        }

        public static ClientDatabaseController ClientDatabaseInstance(string x)
        {
            if (ClientDatabase == null)
                ClientDatabase = new ClientDatabaseController(x);
            return ClientDatabase;
        }

        public Task<List<Client>> GetItemsAsync()
        {
            return database.Table<Client>().ToListAsync();
        }

        public Task<List<Client>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Client>(Query);
        }

        public Task<Client> GetItemAsync(int id)
        {
            return database.Table<Client>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Client item) 
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(Client item)
        {
            return database.DeleteAsync(item);
        }
    }
}