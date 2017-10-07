using System;

namespace ProjectCanine
{
    public class ItemDetailViewModel : ViewModelBase
    {
        public CanineTest Item { get; set; }
        public ItemDetailViewModel(CanineTest item = null)
        {
            Title = item?.ShortName;
            Item = item;
        }
    }
}
