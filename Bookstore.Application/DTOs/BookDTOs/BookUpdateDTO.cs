using Bookstore.Application.DTOs.AuthorDTOs;
using Bookstore.Application.DTOs.GenreDTOs;
using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.StoreDTOs;

namespace Bookstore.Application.DTOs.BookDTOs
{
    public class BookUpdateDTO
    {
        public required string Name { get; set; }
        public int GenreId { get; set; }
        public GenreDTO? Genre { get; set; }
        public int AuthorId { get; set; }
        public AuthorDTO? Author { get; set; }
        public decimal Price { get; set; }
        public List<StoreDTO> Store { get; set; } = new();
        public List<OrderDetailsDTO> OrderDetails { get; set; } = new();

    }

}
