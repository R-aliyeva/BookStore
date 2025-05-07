using Bookstore.Application.DTOs.BookDTOs;

namespace Bookstore.Application.DTOs.StoreDTOs
{
    public class StoreDTO
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Amount { get; set; }
    }
}
