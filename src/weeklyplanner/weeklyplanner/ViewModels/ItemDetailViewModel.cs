using System;

using weeklyplanner.Models;

namespace weeklyplanner.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Title;
            Item = item;
        }
    }
}
