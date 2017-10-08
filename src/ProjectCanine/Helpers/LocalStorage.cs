using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PCLStorage;
using ProjectCanine.Core.Models;

namespace ProjectCanine.Helpers
{
    public class LocalStorage
    {
		private readonly IFolder rootFolder;

		public LocalStorage()
		{
			rootFolder = FileSystem.Current.LocalStorage
				.CreateFolderAsync("ProjectCanine", CreationCollisionOption.OpenIfExists)
				.GetAwaiter()
				.GetResult();
		}
		
		public async Task Save (IEntity entity)
		{
			string fileName = $"{entity.GetType().Name}.{entity.Id.ToString()}.txt";
			IFile file = await rootFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
			await file.WriteAllTextAsync(JsonConvert.SerializeObject(entity));			
		}

		public async Task<T> Get<T>(Guid id)
		{
			string fileName = $"{typeof(T).GetType().Name}.{id.ToString()}.txt";
			IFile file = await rootFolder.GetFileAsync(fileName);
			string contents = await file.ReadAllTextAsync();
			T entity = JsonConvert.DeserializeObject<T>(contents);
			return entity;
		}
	}
}
