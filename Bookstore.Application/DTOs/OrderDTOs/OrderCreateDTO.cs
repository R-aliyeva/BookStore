using Bookstore.Application.DTOs.OrderDetailsDTOs;

namespace Bookstore.Application.DTOs.OrderDTOs;

public class OrderCreateDTO
{
    public int CustomerId { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public List<OrderDetailsCreateDTO> OrderDetails { get; set; } = new();

}
