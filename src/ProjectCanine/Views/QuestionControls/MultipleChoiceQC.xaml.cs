using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class MultipleChoiceQC : ContentView
    {
       
        public MultipleChoiceQC()
        {
            InitializeComponent();


        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();


            var question = BindingContext as FrontPageQuestion;
            if (question == null)
                return;
            
            ListViewAnswers.HeightRequest = question.Items.Count * 50;
        }
    }
}
