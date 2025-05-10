using Bookstore.Application.DTOs.OrderDetailsDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Services;

public class OrderDetailManager : CrudManager<OrderDetails, OrderDetailsDTO, OrderDetailsCreateDTO, OrderDetailsUpdateDTO>
{
}
