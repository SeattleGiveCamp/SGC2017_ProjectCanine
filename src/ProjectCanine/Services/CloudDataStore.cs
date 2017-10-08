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
    public class CloudDataStore : IDataStore<Test>
    {
        private readonly HttpClient client;
		private readonly LocalStorage localStorage;

		IEnumerable<Test> items;

        public CloudDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.BackendUrl}/");

			localStorage = new LocalStorage();

            items = new List<Test>();
        }

        public async Task<IEnumerable<Test>> GetItemsAsync(bool forceRefresh = false)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                var json = await client.GetStringAsync($"api/item");
                items = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Test>>(json));
            } else
			{
				items = await localStorage.GetAll<Test>();
			}

            return items;
        }

        public async Task<Test> GetItemAsync(Guid id)
        {
            if (id != null)
			{
				if (CrossConnectivity.Current.IsConnected)
				{
					var json = await client.GetStringAsync($"api/item/{id}");
					return await Task.Run(() => JsonConvert.DeserializeObject<Test>(json));
				}
				else
				{
					return await localStorage.Get<Test>(id);
				}
            }

            return null;
        }

        public async Task<bool> AddItemAsync(Test item)
        {
			bool result = false;

			if (item != null)
			{
				if (CrossConnectivity.Current.IsConnected)
				{
					var serializedItem = JsonConvert.SerializeObject(item);
					var response = await client.PostAsync($"api/item", new StringContent(serializedItem, Encoding.UTF8, "application/json"));
					result = response.IsSuccessStatusCode;
				}
				else
				{
					await localStorage.Save(item);
					result = true;
				}
			}
			return result;
        }

        public async Task<bool> UpdateItemAsync(Test item)
        {
			bool result = false;

			if (item != null && item.Id != null)
			{
				if (CrossConnectivity.Current.IsConnected)
				{
					var serializedItem = JsonConvert.SerializeObject(item);
					var buffer = Encoding.UTF8.GetBytes(serializedItem);
					var byteContent = new ByteArrayContent(buffer);

					var response = await client.PutAsync(new Uri($"api/item/{item.Id}"), byteContent);

					result = response.IsSuccessStatusCode;
				}
				else
				{
					await localStorage.Save(item);
					result = true;
				}
			}

			return result;            
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
			// TODO: local storage doesn't appear to have a way of deleting a single file, so this will fail if not connected

            if (id != null && !CrossConnectivity.Current.IsConnected)
                return false;

            var response = await client.DeleteAsync($"api/item/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
