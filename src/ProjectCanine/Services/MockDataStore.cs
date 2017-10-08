using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCanine.Core.Models;


namespace ProjectCanine
{
    public class MockDataStore : IDataStore
    {
		List<Test> tests = new List<Test>();
		List<Section> sections = new List<Section>();
		List<Question> questions = new List<Question>();

        public MockDataStore()
        {
			questions = new List<Question> {
				new Question { Text = "question 1.1" },
                new Question { Text = "question 1.2" },
                new Question { Text = "question 1.3" },
                new Question { Text = "question 2.1" },
                new Question { Text = "question 2.2" },
                new Question { Text = "question 2.3" },
                new Question { Text = "question 3.1" }
			};

			sections = new List<Section>
			{
                new Section { Id = Guid.NewGuid(), Title = "Section 1", Description = "This is section 1", Questions = questions },
				new Section { Id = Guid.NewGuid(), Title = "Section 2", Description = "This is section 2" },
				new Section { Id = Guid.NewGuid(), Title = "Section 3", Description = "This is section 3" }
			};

            tests = new List<Test>
            {
                new Test {
                    Id = Guid.NewGuid(),
                    ShortName = "First item",
                    Name="This is first item",
                    Sections = sections
                },
                new Test { Id = Guid.NewGuid(), ShortName = "Second item", Name="2nd" },
                new Test { Id = Guid.NewGuid(), ShortName = "Third item", Name="third thing is here" },
                new Test { Id = Guid.NewGuid(), ShortName = "Fourth item", Name="yes yes yes" },
                new Test { Id = Guid.NewGuid(), ShortName = "Fifth item", Name="Tsire" },
                new Test { Id = Guid.NewGuid(), ShortName = "Sixth item", Name="514234222222" },
            };
        }
		
        public async Task<IEnumerable<Test>> GetTestsAsync()
        {
            return await Task.FromResult(tests);
		}
		public async Task<IEnumerable<Section>> GetSectionsAsync()
		{
			return await Task.FromResult(sections);
		}

		public async Task<IEnumerable<Question>> GetQuestionsAsync()
		{
			return await Task.FromResult(questions);
		}
	}
}
