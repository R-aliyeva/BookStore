namespace BookStore.Domain.Entities;
public class OrderDetails:Entity
{
    public int OrderID {  get; set; }
    public Order? Order { get; set; }
    public int BookId {  get; set; }
    public Book? Book { get; set; }
    public required string OrderStatus { get; set; }
    public int Quantity { get; set; }
}
