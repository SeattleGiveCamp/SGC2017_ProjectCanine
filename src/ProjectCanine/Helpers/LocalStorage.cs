using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PCLStorage;

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

		public async Task<T> Save<T>(T entity)
		{
			return await Task.FromResult(default(T));
		}
		/*
		 * IFolder rootFolder = FileSystem.Current.LocalStorage;
    IFolder folder = await rootFolder.CreateFolderAsync("MySubFolder",
        CreationCollisionOption.OpenIfExists);
    IFile file = await folder.CreateFileAsync("answer.txt",
        CreationCollisionOption.ReplaceExisting);
    await file.WriteAllTextAsync("42");
	*/
	}
}
