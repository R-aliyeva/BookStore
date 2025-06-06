﻿namespace Bookstore.Application.DTOs.OrderDetailsDTOs;

public class OrderDetailsUpdateDTO
{
    public int Id {  get; set; }
    public int OrderID { get; set; }
    //public OrderDTO? Order { get; set; }
    public int BookId { get; set; }
    //public BookDTO? Book { get; set; }
    public required string OrderStatus { get; set; }
    public int Quantity { get; set; }
}
