using Bookstore.Application.DTOs.CustomerDTOs;
using Bookstore.Application.DTOs.OrderDetailsDTOs;

namespace Bookstore.Application.DTOs.OrderDTOs
{
    public class OrderUpdateDTO
    {
        public int CustomerId { get; set; }
        public CustomerDTO? Customer { get; set; }
        public DateTime Date { get; set; }
        public List<OrderDetailsDTO> OrderDetails { get; set; } = new();

    }
}
