namespace Bookstore.Application.DTOs.BookDTOs;

public class BookDTO
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int GenreId { get; set; }
    public required string GenreName {  get; set; }
    public int AuthorId {  get; set; }  
    public required string AuthorFullName { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    //public List<OrderDetailsDTO> OrderDetails { get; set; } = new();
}
