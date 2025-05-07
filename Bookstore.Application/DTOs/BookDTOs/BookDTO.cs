using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.StoreDTOs;

namespace Bookstore.Application.DTOs.BookDTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string GenreName {  get; set; }
        public required string AuthorName { get; set; }
        public decimal Price { get; set; }
        public List<StoreDTO> Store { get; set; } = new();
        public List<OrderDetailsDTO> OrderDetails { get; set; } = new();

    }

}
