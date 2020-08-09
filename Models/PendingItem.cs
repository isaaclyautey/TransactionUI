namespace TransactionUI.Models
{
    public class PendingItem: IBaseModel
    {
        public int ID { get; set; }
        public double Progress { get; set; } = 0;
        public string Name { get; set; }
    }
}