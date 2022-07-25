using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class CertificationDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static CertificationDatabaseController CertificationDatabase = null;
        public CertificationDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Certification>().Wait();
        }

        public static CertificationDatabaseController CertificationDatabaseInstance(string x)
        {
            if (CertificationDatabase == null)
                CertificationDatabase = new CertificationDatabaseController(x);
            return CertificationDatabase;
        }

        public Task<List<Certification>> GetItemsAsync()
        {
            return database.Table<Certification>().ToListAsync();
        }

        public Task<List<Certification>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Certification>(Query);
        }

        public Task<Certification> GetItemAsync(int id)
        {
            return database.Table<Certification>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Certification item)
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);
        }
        public Task<int> DeleteItemAsync(Certification item)
        {
            return database.DeleteAsync(item);
        }
    }
}