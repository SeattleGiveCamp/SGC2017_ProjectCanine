using System;
using System.Collections.Generic;
using System.Linq;
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
			T entity = default(T);

			string fileName = $"{typeof(T).GetType().Name}.{id.ToString()}.txt";
			IFile file = await rootFolder.GetFileAsync(fileName);

			if (file != null)
			{
				string contents = await file.ReadAllTextAsync();
				entity = JsonConvert.DeserializeObject<T>(contents);
			}

			return entity;
		}

		public async Task<IEnumerable<T>> GetAll<T>()
		{
			string prefix = $"{typeof(T).GetType().Name}";

			var files = (await rootFolder.GetFilesAsync())
				.Where(x => x.Name.StartsWith(prefix)).ToList();

			var entities = new List<T>();

			foreach (var file in files)
			{
				string contents = await file.ReadAllTextAsync();
				T entity = JsonConvert.DeserializeObject<T>(contents);

				if (entity != null)
					entities.Add(entity);
			}

			return entities;
		}
	}
}
