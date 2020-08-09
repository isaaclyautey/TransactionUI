namespace TransactionUI.Services
{
    using System.Collections;
    using System.Collections.Generic;
    using TransactionUI.Models;

    public class Database
    {
        public IEnumerable<PendingItem> GetPendingItems() => new[]
        {
            new PendingItem {Name = "Task 1"},
            new PendingItem {Name = "Task 2"}
        };
}
}