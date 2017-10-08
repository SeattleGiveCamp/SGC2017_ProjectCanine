using System;
using System.Collections.Generic;
using ProjectCanine.Core.Models;

namespace ProjectCanine
{
    public class TestSectionQuestionsViewModel
    {
        public MCQuestionData ExampleMC { get; }

        public TestSectionQuestionsViewModel(Test item = null)
        {
			ExampleMC = new MCQuestionData
			{
				Title = "Example",
				Items = new List<String>() {
    				"first",
    				"second",
    				"third"
    			}
			};
        }
    }
}
