using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using ProjectCanine.Core.Models;

namespace ProjectCanine
{
    public interface IDataStore
    {
        Task<IEnumerable<Test>> GetTestsAsync();
		Task<IEnumerable<Section>> GetSectionsAsync();
		Task<IEnumerable<Question>> GetQuestionsAsync();
	}
}
