using AutoMapper;
using Bookstore.Application.DTOs.AuthorDTOs;
using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.DTOs.CustomerDTOs;
using Bookstore.Application.DTOs.GenreDTOs;
using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.OrderDTOs;
using Bookstore.Application.DTOs.StoreDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.AutoMapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Author,AuthorDTO>().ReverseMap();
            CreateMap<Author, AuthorCreateDTO>().ReverseMap();

            CreateMap<Book, BookDTO>().ForMember(x => x.GenreName, opt => opt.MapFrom(src => src.Genre.Name)).ReverseMap();
            CreateMap<Book,BookDTO>().ForMember(x => x.AuthorName, opt => opt.MapFrom(src => src.Author.Name)).ReverseMap();
            CreateMap<Book, BookCreateDTO>().ReverseMap();

            CreateMap<Customer,CustomerDTO>().ReverseMap();
            CreateMap<Customer, CustomerCreateDTO>().ReverseMap();
            CreateMap<Customer, CustomerUpdateDTO>().ReverseMap();

            CreateMap<Genre,GenreDTO>().ReverseMap();
            CreateMap<Genre, GenreCreateDTO>().ReverseMap();
            CreateMap<Genre, GenreUpdateDTO>().ReverseMap();

            CreateMap<OrderDetails,OrderDetailsDTO>().ReverseMap();
            CreateMap<OrderDetails, OrderDetailsCreateDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Order, OrderCreateDTO>().ReverseMap();
            CreateMap<Store,StoreDTO>().ReverseMap();
            CreateMap<Store, StoreCreateDTO>().ReverseMap();

        }
    }
}
