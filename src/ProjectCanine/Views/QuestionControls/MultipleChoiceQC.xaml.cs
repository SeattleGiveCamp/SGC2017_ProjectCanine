using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class MultipleChoiceQC : ContentView
    {
        public static BindableProperty ItemsProperty;
        public static BindableProperty TitleProperty;

        public MultipleChoiceQC()
        {
            InitializeComponent();
            ItemsProperty = BindableProperty.Create("Items", typeof(List<String>), typeof(MultipleChoiceQC), new List<String>());
            TitleProperty = BindableProperty.Create("Title", typeof(String), typeof(MultipleChoiceQC), "Multiple Choice label");
            BindingContext = this;
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
