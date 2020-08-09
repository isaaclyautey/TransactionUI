using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using ReactiveUI;
using TransactionUI.Models;
using TransactionUI.Services;

namespace TransactionUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase content;
        public MainWindowViewModel(Database database)
        {
            Content = PendingItemListViewModel = new PendingItemListViewModel(database.GetPendingItems());

            AddItem = ReactiveCommand.Create(() =>
            {
                PendingItemListViewModel.Items.Add(new PendingItem() {Name = "New Item"});
            });
        }
        
        public string Greeting => "Hello World!";
        public PendingItemListViewModel PendingItemListViewModel { get; }

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public ReactiveCommand<Unit, Unit> AddItem { get; }
    }
}
