using Bookstore.Application.DTOs.StoreDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Services
{
    public class StoreManager : CrudManager<Store, StoreDTO, StoreCreateDTO, StoreUpdateDTO>
    {
    }
}
