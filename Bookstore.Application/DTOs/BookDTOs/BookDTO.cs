using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.StoreDTOs;

namespace Bookstore.Application.DTOs.BookDTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string GenreName {  get; set; }
        public required string AuthorFullName { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        //public List<OrderDetailsDTO> OrderDetails { get; set; } = new();
    }
}
