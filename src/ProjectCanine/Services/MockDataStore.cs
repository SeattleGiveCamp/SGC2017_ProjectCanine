using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCanine.Common.Models;


namespace ProjectCanine
{
    public class MockDataStore : IDataStore<Test>
    {
        List<Test> items;

        public MockDataStore()
        {
            items = new List<Test>();
            var mockItems = new List<Test>
            {
                new Test { Id = 1, ShortName = "First item", Name="This is an item description." },
                new Test { Id = 2, ShortName = "Second item", Name="This is an item description." },
                new Test { Id = 3, ShortName = "Third item", Name="This is an item description." },
                new Test { Id = 4, ShortName = "Fourth item", Name="This is an item description." },
                new Test { Id = 5, ShortName = "Fifth item", Name="This is an item description." },
                new Test { Id = 6, ShortName = "Sixth item", Name="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Test item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Test item)
        {
            var _item = items.Where((Test arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var _item = items.Where((Test arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Test> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Test>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
