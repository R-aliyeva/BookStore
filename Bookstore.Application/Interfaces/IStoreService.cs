using Bookstore.Application.DTOs.StoreDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Interfaces
{
    public interface IStoreService : ICrudService<Store, StoreDTO, StoreCreateDTO, StoreUpdateDTO>
    {
    }
}
