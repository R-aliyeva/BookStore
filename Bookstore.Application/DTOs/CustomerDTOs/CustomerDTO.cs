namespace Bookstore.Application.DTOs.CustomerDTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
    }
}
