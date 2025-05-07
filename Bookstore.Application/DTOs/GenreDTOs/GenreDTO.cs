using Bookstore.Application.DTOs.BookDTOs;

namespace Bookstore.Application.DTOs.GenreDTOs
{
    public class GenreDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<BookDTO> Books { get; set; } = new();
    }
}
