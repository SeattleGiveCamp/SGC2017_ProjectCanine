using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class SignatureQC : ContentView
    {
        public static BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(String), typeof(SignatureQC), "Signature label");
        public SignatureQC()
        {
            InitializeComponent();
            BindingContext = this;
        }

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
    }
}
