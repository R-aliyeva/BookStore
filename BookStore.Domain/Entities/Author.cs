namespace BookStore.Domain.Entities;
public class Author:Entity
{
    public required string Name { get; set; }
    public required string SurName { get; set; }
    public DateTime Birthdate { get; set; }
    public required string Birthplace { get; set; }
    public required string Nationality { get; set; }
    public List<Book> Books { get; set; } = new();
}
