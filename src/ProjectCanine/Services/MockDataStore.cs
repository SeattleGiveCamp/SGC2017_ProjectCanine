using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCanine.Core.Models;


namespace ProjectCanine
{
    public class MockDataStore : IDataStore<Test>
    {
        List<Test> items;

        public MockDataStore()
        {
            items = new List<Test>();
            IEnumerable<Question> firstQuestions = new List<Question> {
                new Question { Text = "question 1.1", SectionNumber=1 },
                new Question { Text = "question 1.2", SectionNumber=1 },
                new Question { Text = "question 1.3", SectionNumber=1 },
                new Question { Text = "question 2.1", SectionNumber=2 },
                new Question { Text = "question 2.2", SectionNumber=2 },
                new Question { Text = "question 2.3", SectionNumber=2 },
                new Question { Text = "question 3.1", SectionNumber=3 }
            };

            var mockItems = new List<Test>
            {
                new Test {
                    Id = Guid.NewGuid(),
                    ShortName = "First item",
                    Name="This is first item",
                    Questions = firstQuestions
                },
                new Test { Id = Guid.NewGuid(), ShortName = "Second item", Name="2nd" },
                new Test { Id = Guid.NewGuid(), ShortName = "Third item", Name="third thing is here" },
                new Test { Id = Guid.NewGuid(), ShortName = "Fourth item", Name="yes yes yes" },
                new Test { Id = Guid.NewGuid(), ShortName = "Fifth item", Name="Tsire" },
                new Test { Id = Guid.NewGuid(), ShortName = "Sixth item", Name="514234222222" },
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

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            var _item = items.Where((Test arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Test> GetItemAsync(Guid id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Test>> GetItemsAsync()
        {
            return await Task.FromResult(items);
        }
    }
}
