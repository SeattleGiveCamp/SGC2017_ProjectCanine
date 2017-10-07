using System;

namespace ProjectCanine
{
    public class TestFrontPageViewModel : ViewModelBase
    {
        public Test Item { get; set; }
        public TestFrontPageViewModel(Test item = null)
        {
            Title = item?.ShortName;
            Item = item;
        }
    }
}
