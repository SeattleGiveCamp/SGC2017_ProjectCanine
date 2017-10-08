using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectCanine
{
    [Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
    public partial class MultipleChoiceQC : ContentView
    {
       
        public MultipleChoiceQC()
        {
            InitializeComponent();

        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();


            var question = BindingContext as MCQuestionData;
            if (question == null)
                return;
            
            ListViewAnswers.HeightRequest = question.Items.Count * 75;
        }

       
    }
}
