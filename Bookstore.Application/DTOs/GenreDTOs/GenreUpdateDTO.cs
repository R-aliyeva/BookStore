using Bookstore.Application.DTOs.BookDTOs;

namespace Bookstore.Application.DTOs.GenreDTOs
{
    public class GenreUpdateDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
