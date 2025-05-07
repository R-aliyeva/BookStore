using Bookstore.Application.DTOs.BookDTOs;

namespace Bookstore.Application.DTOs.AuthorDTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string SurName { get; set; }
        public DateTime Birthdate { get; set; }
        public required string Birthplace { get; set; }
        public required string Nationality { get; set; }
        public List<BookDTO> Books { get; set; } = new();
    }
}
