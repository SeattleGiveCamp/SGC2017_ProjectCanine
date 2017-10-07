using System;

namespace ProjectCanine
{
    public class TestFrontPageViewModel : ViewModelBase
    {
        public CanineTest Item { get; set; }
        public TestFrontPageViewModel(CanineTest item = null)
        {
            Title = item?.ShortName;
            Item = item;
        }
    }
}
