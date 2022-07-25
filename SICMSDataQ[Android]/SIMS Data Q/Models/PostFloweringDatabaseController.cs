using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS_BARS.Data;

namespace SIMS_BARS.Models
{
    public class PostFloweringDatabaseController
    {
        readonly SQLite.SQLiteAsyncConnection database;
        private static PostFloweringDatabaseController PostFloweringDatabase = null;
        public PostFloweringDatabaseController(string db_path) 
        {
            database = new SQLite.SQLiteAsyncConnection(db_path);
            database.CreateTableAsync<PostFlowering>().Wait();
        }

        public static PostFloweringDatabaseController PostFloweringDatabaseInstance(string x)
        {
            if (PostFloweringDatabase == null)
                PostFloweringDatabase = new PostFloweringDatabaseController(x);
            return PostFloweringDatabase;
        }

        public Task<List<PostFlowering>> GetItemsAsync()
        {
            return database.Table<PostFlowering>().ToListAsync();
        }

        public Task<List<PostFlowering>> GetItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<PostFlowering>(Query);
        }

        public Task<PostFlowering> GetItemAsync(int id)
        {
            return database.Table<PostFlowering>().Where(i => i.post_flowering_id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(PostFlowering item) 
        {
            if (item.post_flowering_id != 0)
                return database.UpdateAsync(item);
            else
                return database.InsertAsync(item);        
        }
        public Task<int> DeleteItemAsync(PostFlowering item)
        {
            return database.DeleteAsync(item);
        }
    }
}