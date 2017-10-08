using System;
using System.Collections.Generic;
using ProjectCanine.Core.Models;

namespace ProjectCanine
{
    public class TestSectionQuestionsViewModel
    {
        public List<MCQuestionData> QuestionTexts { get; set; }

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
        }
    }
}
