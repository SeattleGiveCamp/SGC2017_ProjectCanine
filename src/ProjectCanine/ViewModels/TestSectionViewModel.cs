using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ProjectCanine.Core.Models;

namespace ProjectCanine
{
	public class TestSectionViewModel : ViewModelBase
	{
        public Test TestItem { get; set; }
        public ObservableCollection<Test> Items { get; set; }

        public Page Page { get; set; }
		public Test TestObject { get; set; }

		public TestSectionViewModel(Page page, Test item = null)
		{
			Page = page;
			Title = item?.ShortName;
			TestObject = item;
			PassCommand = new Command(async () => await ExecutePassCommand());
			FailCommand = new Command(async () => await ExecuteFailCommand());

		}

		public TestSectionViewModel()
		{
			Title = "Choose a Section";
			Items = new ObservableCollection<Test>();
			
		}

        public TestSectionViewModel(Test item = null) {
            TestItem = item;
        }

		public Command PassCommand { get; }
		public Command FailCommand { get; }

		async Task ExecutePassCommand()
		{
			await Page.Navigation.PushAsync(new SignatureTestPage());
		}

		async Task ExecuteFailCommand()
		{
			await Page.Navigation.PushAsync(new FailedTestPage());
		}
	}
}
