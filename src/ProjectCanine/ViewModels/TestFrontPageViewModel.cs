using System;
using System.Collections.ObjectModel;
using ProjectCanine.Core.Models;
using System.Collections.Generic;


namespace ProjectCanine
{
    public class TestFrontPageViewModel : ViewModelBase
    {
        public Test TestObject { get; set; }
        //public ObservableCollection<Question> FrontPageQuestions { get; set; }

        public TestFrontPageViewModel(Test item = null)
        {
            Title = item?.ShortName;
            TestObject = item;
            //FrontPageQuestions = new ObservableCollection<Question>();

            //foreach (Question question in TestObject.Questions){
            //    if (question.SectionNumber == 1) {
            //        FrontPageQuestions.Add(question);    
            //    }
            //} 
        }
    }
}
