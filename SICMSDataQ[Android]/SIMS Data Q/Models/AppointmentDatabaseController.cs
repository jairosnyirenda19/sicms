using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class AppointmentDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static AppointmentDatabaseController AppointmentDatabase = null;
        public AppointmentDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<Appointment>().Wait();
        }

        public static AppointmentDatabaseController AppointmentDatabaseInstance(string x)
        {
            if (AppointmentDatabase == null)
                AppointmentDatabase = new AppointmentDatabaseController(x);
            return AppointmentDatabase;
        }

        public Task<List<Appointment>> GetItemsAsync()
        {
            return database.Table<Appointment>().ToListAsync();
        }

        public Task<List<Appointment>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<Appointment>(Query);
        }

        public Task<Appointment> GetItemAsync(int id)
        {
            return database.Table<Appointment>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Appointment item)
        {
            if (item.id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);
        }
        public Task<int> DeleteItemAsync(Appointment item)
        {
            return database.DeleteAsync(item);
        }
    }
}