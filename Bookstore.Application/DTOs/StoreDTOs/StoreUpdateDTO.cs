using Bookstore.Application.DTOs.BookDTOs;

namespace Bookstore.Application.DTOs.StoreDTOs
{
    public class StoreUpdateDTO
    {
        public int BookId { get; set; }
        public BookDTO? Book { get; set; }
        public int Amount { get; set; }
    }
}
