namespace TransactionUI.ViewModels
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reactive;
    using ReactiveUI;
    using TransactionUI.Models;

    public class PendingItemListViewModel: ViewModelBase
    {
        public PendingItemListViewModel(IEnumerable<PendingItem> pendingItems)
        {
            Items = new ObservableCollection<PendingItem>(pendingItems);
            AddItemCommand = ReactiveCommand.Create(AddItem);
            RemoveItemCommand = ReactiveCommand.Create<PendingItem>(RemoveItem);
        }
        
        public ObservableCollection<PendingItem> Items { get; }
        public ReactiveCommand<Unit, Unit> AddItemCommand { get; }
        public ReactiveCommand<PendingItem, Unit> RemoveItemCommand { get; }

        public void AddItem()
        {
            Items.Add(new PendingItem() {Name = "New Item"});
        }

        public void RemoveItem(PendingItem pendingItem)
        {
            Items.Remove(pendingItem);
        }
    }
}