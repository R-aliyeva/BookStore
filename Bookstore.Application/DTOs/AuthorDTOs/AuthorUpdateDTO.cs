namespace Bookstore.Application.DTOs.AuthorDTOs
{
    public class AuthorUpdateDTO 
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string SurName { get; set; }
        public DateTime Birthdate { get; set; }
        public required string Birthplace { get; set; }
        public required string Nationality { get; set; }


    }
}
