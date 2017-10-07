using System;

namespace ProjectCanine
{
    public class ItemDetailViewModel : ViewModelBase
    {
        public Test Item { get; set; }
        public ItemDetailViewModel(Test item = null)
        {
            Title = item?.ShortName;
            Item = item;
        }
    }
}
