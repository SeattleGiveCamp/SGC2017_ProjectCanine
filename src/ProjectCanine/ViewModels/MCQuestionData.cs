using System;
using System.Collections.Generic;
using MvvmHelpers;

namespace ProjectCanine
{
	public class MCQuestionData : ObservableObject
	{
		public string Title { get; set; }
		public List<String> Items { get; set; }

		string selectedItem;
		public string SelectedItem
		{
			get => selectedItem;
			set => SetProperty(ref selectedItem, value);
		}
	}
}
