using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TransactionUI.Models;

namespace TransactionUI.ViewModels
{
    public class PendingItemListViewModel: ViewModelBase
    {
        public PendingItemListViewModel(IEnumerable<PendingItem> pendingItems)
        {
            Items = new ObservableCollection<PendingItem>(pendingItems);
        }
        
        public ObservableCollection<PendingItem> Items { get; }
    }
}