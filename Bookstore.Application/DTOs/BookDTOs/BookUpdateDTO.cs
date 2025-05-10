using Bookstore.Application.DTOs.OrderDetailsDTOs;


namespace Bookstore.Application.DTOs.BookDTOs;

public class BookUpdateDTO
{
    public int Id { get; set; } 
    public required string Name { get; set; }
    public int GenreId { get; set; }
    //public GenreDTO? Genre { get; set; }
    public int AuthorId { get; set; }
    //public AuthorDTO? Author { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public List<OrderDetailsDTO> OrderDetails { get; set; } = new();
}
