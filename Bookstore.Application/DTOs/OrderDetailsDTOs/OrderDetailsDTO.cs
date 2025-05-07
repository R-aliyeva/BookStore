using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.DTOs.OrderDTOs;

namespace Bookstore.Application.DTOs.OrderDetailsDTOs
{
    public class OrderDetailsDTO
    {
        public int OrderID { get; set; }
        //public OrderDTO? Order { get; set; }
        public required string BookName { get; set; }
        //public BookDTO? Book { get; set; }
        public required string OrderStatus { get; set; }
        public int Quantity { get; set; }
    }
}
