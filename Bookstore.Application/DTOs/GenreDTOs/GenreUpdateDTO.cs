using Bookstore.Application.DTOs.BookDTOs;

namespace Bookstore.Application.DTOs.GenreDTOs
{
    public class GenreUpdateDTO
    {
        public required string Name { get; set; }
        public List<BookDTO> Books { get; set; } = new();
    }
}
