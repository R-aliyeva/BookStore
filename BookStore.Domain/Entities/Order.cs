namespace BookStore.Domain.Entities
{
    public class Order:Entity
    {
        public int CustomerId {  get; set; }
        public Customer? Customer { get; set; }
        public DateTime Date { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new();

    }
}
