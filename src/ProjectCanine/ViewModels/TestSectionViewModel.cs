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

		public TestSectionViewModel()
		{
			Title = "Choose a Section";
			Items = new ObservableCollection<Test>();
			
		}

        public TestSectionViewModel(Test item = null) {
            TestItem = item;
        }
	}
}
