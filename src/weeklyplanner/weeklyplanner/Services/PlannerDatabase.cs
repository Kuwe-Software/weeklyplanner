using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using weeklyplanner.Models;

namespace weeklyplanner.Services
{
	public class PlannerDatabase : IDataStore<Item>
	{
		readonly SQLiteAsyncConnection database;
		public PlannerDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Item>().Wait();
		}
		public async Task<int> AddItemAsync(Item item)
		{
			return await database.InsertAsync(item);
		}

		public async Task<int> DeleteItemAsync(Item item)
		{
			return await database.DeleteAsync(item);
		}

		public async Task<Item> GetItemAsync(int id)
		{
			return await database.Table<Item>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}

		public async Task<List<Item>> GetItemsAsync(bool forceRefresh = false)
		{
			return await database.Table<Item>().ToListAsync();
		}

		public async Task<int> UpdateItemAsync(Item item)
		{
			return await database.UpdateAsync(item);
		}
	}
}
