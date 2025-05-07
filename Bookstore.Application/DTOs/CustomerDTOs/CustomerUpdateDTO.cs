namespace Bookstore.Application.DTOs.CustomerDTOs
{
    public class CustomerUpdateDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
    }
}
