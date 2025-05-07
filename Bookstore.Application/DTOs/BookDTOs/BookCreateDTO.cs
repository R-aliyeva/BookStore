using Bookstore.Application.DTOs.OrderDetailsDTOs;

namespace Bookstore.Application.DTOs.BookDTOs
{
    public class BookCreateDTO
    {
        public required string Name { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public List<OrderDetailsDTO> OrderDetails { get; set; } = new();
    }
}
