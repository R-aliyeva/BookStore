﻿namespace Bookstore.Application.DTOs.OrderDetailsDTOs;

public class OrderDetailsCreateDTO
{
    public int OrderID { get; set; }
    //public OrderDTO? Order { get; set; }
    public int BookId { get; set; }
    //public BookDTO? Book { get; set; }
    public string OrderStatus { get; set; } = "Pending";
    public int Quantity { get; set; }
}
