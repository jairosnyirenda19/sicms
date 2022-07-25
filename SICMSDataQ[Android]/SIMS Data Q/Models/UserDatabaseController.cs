using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class UserDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static UserDatabaseController userDatabase = null;
        public UserDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<User>().Wait();
        }

        public static UserDatabaseController UserDatabaseInstance(string x) 
        {
            if (userDatabase == null)
                userDatabase = new UserDatabaseController(x);
            return userDatabase;
        }

        public Task<List<User>> GetItemsAsync()
        {
            return database.Table<User>().ToListAsync();
        }

        public Task<List<User>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<User>(Query);
        }

        public Task<User> GetItemAsync(int id)
        {
            return database.Table<User>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(User item) 
        {
            if (item.Id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(User item)
        {
            return database.DeleteAsync(item);
        }
    }
}