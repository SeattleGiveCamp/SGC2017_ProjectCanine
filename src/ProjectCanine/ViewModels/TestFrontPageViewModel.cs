using System;
using System.Collections.ObjectModel;
using ProjectCanine.Core.Models;
using System.Collections.Generic;


namespace ProjectCanine
{
    public class TestFrontPageViewModel : ViewModelBase
    {
        public Test TestObject { get; set; }

        public String CertificationTitle { get; set; }
        public List<String> CertificationOptions { get; set; }

        public TestFrontPageViewModel(Test item = null)
        {
            Title = item?.ShortName;
            TestObject = item;
            CertificationTitle = "Type of Certification";
            CertificationOptions = new List<String>() {
                "New adult certification",
                "Junior handler certification (under 18 yrs of age)",
                "Adult recertification",
                "Puppy-to-adult dog certification"
            };
        }
    }
}
