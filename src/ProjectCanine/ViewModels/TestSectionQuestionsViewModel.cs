using System;
using System.Collections.Generic;
using ProjectCanine.Core.Models;
using System.Collections.ObjectModel;
using MvvmHelpers;
using Xamarin.Forms;
using System.Threading.Tasks;
using ProjectCanine;

namespace ProjectCanine
{
    public class TestSectionQuestionsViewModel : ViewModelBase
    {
        public Section Section { get; set; }
        public List<MCQuestionData> QuestionTexts { get; set; }

		public Test TestObject { get; set; }
        public Page Page { get; set; }

       
        public TestSectionQuestionsViewModel(Section item = null)
        {
            List<MCQuestionData> questionTexts = new List<MCQuestionData>();

           
            foreach (Question q in item.Questions) {
                questionTexts.Add(new MCQuestionData
                {
                    Title = q.Text,
                    Items = new List<MCItem> {
                        new MCItem("Present"),
                        new MCItem("Emerging"),
                        new MCItem("Not Present")
                    }
                });
            }

            QuestionTexts = questionTexts;
            Section = item;
        }

		
    }
}
