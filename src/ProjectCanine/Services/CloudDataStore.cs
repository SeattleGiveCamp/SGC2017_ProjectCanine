using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Plugin.Connectivity;
using ProjectCanine.Core.Models;
using ProjectCanine.Helpers;

namespace ProjectCanine
{
    public class CloudDataStore : IDataStore
    {
        private readonly HttpClient client;
		private readonly LocalStorage localStorage;
		
        public CloudDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.AzureFunctionUrl}/");

			localStorage = new LocalStorage();            
        }

        public async Task<IEnumerable<Test>> GetTestsAsync()
        {
			IEnumerable<Test> items = new List<Test>();

			if (CrossConnectivity.Current.IsConnected)
            {
                var json = await client.GetStringAsync($"api/gettests?code={App.AzureFunctionKey}");
                items = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Test>>(json));
				// TODO: Save to local storage
            } else
			{
				items = await localStorage.GetAll<Test>();
			}

            return items;
        }
		public async Task<IEnumerable<Section>> GetSectionsAsync()
		{
			IEnumerable<Section> items = new List<Section>();

			if (CrossConnectivity.Current.IsConnected)
			{
				var json = await client.GetStringAsync($"api/getsections?code={App.AzureFunctionKey}");
				items = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Section>>(json));
				// TODO: Save to local storage
			}
			else
			{
				items = await localStorage.GetAll<Section>();
			}

			return items;
		}
		public async Task<IEnumerable<Question>> GetQuestionsAsync()
		{
			IEnumerable<Question> items = new List<Question>();

			if (CrossConnectivity.Current.IsConnected)
			{
				var json = await client.GetStringAsync($"api/getquestions?code={App.AzureFunctionKey}");
				items = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Question>>(json));
				// TODO: Save to local storage
			}
			else
			{
				items = await localStorage.GetAll<Question>();
			}

			return items;
		}


		// TODO: Logic for saving results
		/*
        public async Task<bool> AddResultAsync(Test item)
        {
			bool result = false;

			if (item != null)
			{
				result = true;

				if (CrossConnectivity.Current.IsConnected)
				{
					var serializedItem = JsonConvert.SerializeObject(item);
					var response = await client.PostAsync($"api/item?code={App.AzureFunctionKey}", new StringContent(serializedItem, Encoding.UTF8, "application/json"));
					result = response.IsSuccessStatusCode;
				}

				await localStorage.Save(item);
			}
			return result;
        }

        public async Task<bool> UpdateItemAsync(Test item)
        {
			bool result = false;

			if (item != null && item.Id != null)
			{
				result = true;

				if (CrossConnectivity.Current.IsConnected)
				{
					var serializedItem = JsonConvert.SerializeObject(item);
					var buffer = Encoding.UTF8.GetBytes(serializedItem);
					var byteContent = new ByteArrayContent(buffer);

					var response = await client.PutAsync(new Uri($"api/item/{item.Id}?code={App.AzureFunctionKey}"), byteContent);

					result = response.IsSuccessStatusCode;
				}

				await localStorage.Save(item);
			}

			return result;            
        }

        public async Task<bool> DeleteTestAsync(Guid id)
        {
			// TODO: local storage doesn't appear to have a way of deleting a single file, so this will fail if not connected

            if (id != null && !CrossConnectivity.Current.IsConnected)
                return false;

            var response = await client.DeleteAsync($"api/item/{id}?code={App.AzureFunctionKey}");

            return response.IsSuccessStatusCode;
        }
		*/

		public async Task Sync()
		{
			//TODO: Watch for network availability changes and call this method

			//TODO: Save all items in local storage which don't exist remotely
			//		Update all items which are newer in local storage
			//		Get all remote items not in local storage

			//		Implementation strategy: one webapi method which takes the list, then returns the new list
			
		}
    }
}
