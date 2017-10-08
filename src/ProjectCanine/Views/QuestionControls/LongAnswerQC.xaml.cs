using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class LongAnswerQC : ContentView
    {
        public static BindableProperty TitleProperty;
        public LongAnswerQC()
        {
            InitializeComponent();
            TitleProperty = BindableProperty.Create("Title", typeof(String), typeof(LongAnswerQC), "Long answer label");
            BindingContext = this;
        }

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
    }
}
