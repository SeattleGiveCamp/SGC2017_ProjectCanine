using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class ShortAnswerQC : ContentView
    {
        public static BindableProperty TitleProperty;
        public ShortAnswerQC()
        {
            InitializeComponent();
            TitleProperty = BindableProperty.Create("Title", typeof(String), typeof(ShortAnswerQC), "Short answer label");
            BindingContext = this;
        }

        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
    }
}
