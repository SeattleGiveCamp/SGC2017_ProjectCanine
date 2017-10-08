using System;
using System.Collections.Generic;
using System.Linq;
using MvvmHelpers;

namespace ProjectCanine
{
	public class MCItem : ObservableObject
	{
        public MCItem(string text) => Text = text;

		public string Text { get; set; }
		bool selected;
		public bool Selected
		{
			get => selected;
			set => SetProperty(ref selected, value);
		}
	}

	public class MCQuestionData : ObservableObject
	{

       
		public string Title { get; set; }
		public List<MCItem> Items { get; set; }

		MCItem selectedItem;
		public MCItem SelectedItem
		{
			get => selectedItem;
			set
            {
                if (selectedItem != null)
                    selectedItem.Selected = false;
                
                 
                SetProperty(ref selectedItem, value);
               
                if (selectedItem != null)
                    selectedItem.Selected = true;
            }
		}
	}

	public class ShortQuestionData : ObservableObject
	{
		public string Title { get; set; }

		string text;
		public string Text
		{
			get => text;
			set => SetProperty(ref text, value);
		}
	}

	public class LongQuestionData : ObservableObject
	{
		public string Title { get; set; }

		string text;
		public string Text
		{
			get => text;
			set => SetProperty(ref text, value);
		}
	}
}
