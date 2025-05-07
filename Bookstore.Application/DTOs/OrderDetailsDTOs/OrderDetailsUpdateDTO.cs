using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.DTOs.OrderDTOs;

namespace Bookstore.Application.DTOs.OrderDetailsDTOs
{
    public class OrderDetailsUpdateDTO
    {
        public int OrderID { get; set; }
        public OrderDTO? Order { get; set; }
        public int BookId { get; set; }
        public BookDTO? Book { get; set; }
        public required string OrderStatus { get; set; }
        public int Quantity { get; set; }
    }
}
