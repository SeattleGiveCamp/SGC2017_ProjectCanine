using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCanine
{
    public class MockDataStore : IDataStore<CanineTest>
    {
        List<CanineTest> items;

        public MockDataStore()
        {
            items = new List<CanineTest>();
            var mockItems = new List<CanineTest>
            {
                new CanineTest { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new CanineTest { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new CanineTest { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new CanineTest { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new CanineTest { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new CanineTest { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(CanineTest item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(CanineTest item)
        {
            var _item = items.Where((CanineTest arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((CanineTest arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<CanineTest> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<CanineTest>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
