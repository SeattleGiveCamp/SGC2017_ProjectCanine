using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectCanine
{
	public class TestSectionViewModel : ViewModelBase
	{
		public ObservableCollection<Test> Items { get; set; }
		public Command LoadItemsCommand { get; set; }

		public TestSectionViewModel()
		{
			Title = "Choose a Section";
			Items = new ObservableCollection<Test>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
		}

		async Task ExecuteLoadItemsCommand()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			try
			{
				Items.Clear();
				var items = await DataStore.GetItemsAsync(true);
				foreach (var item in items)
				{
					Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			finally
			{
				IsBusy = false;
			}
		}
	}
}
