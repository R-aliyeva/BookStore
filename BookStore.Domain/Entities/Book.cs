namespace BookStore.Domain.Entities;
public class Book:Entity
{
    public  required string Name { get; set; }
    public int GenreId {  get; set; }
    public Genre? Genre { get; set; }
    public int AuthorId {  get; set; }
    public Author? Author { get; set; }
    public decimal Price { get; set; }
    public int Amount {  get; set; }
    public List<OrderDetails> OrderDetails { get; set; } = new();
}
