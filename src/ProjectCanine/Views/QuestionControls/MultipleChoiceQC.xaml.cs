using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class MultipleChoiceQC : ContentView
    {
        public static BindableProperty ItemsProperty = BindableProperty.Create("Title", typeof(String), typeof(MultipleChoiceQC), "Multiple Choice label") ;
        public static BindableProperty TitleProperty = BindableProperty.Create("Items", typeof(List<String>), typeof(MultipleChoiceQC), new List<String>());

        public MultipleChoiceQC()
        {
            InitializeComponent();
        }

        public List<String> Items
        {
            get { return (List<String>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value);}
        }

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
    }
}
