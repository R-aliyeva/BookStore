using AutoMapper;
using Bookstore.Application.DTOs.AuthorDTOs;
using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.DTOs.CustomerDTOs;
using Bookstore.Application.DTOs.GenreDTOs;
using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.OrderDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.AutoMapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AuthorDTO, Author>().ReverseMap()
            .ForMember(x=>x.FullName,opt =>opt.MapFrom(src=>(src.Name+ " "+src.SurName)));
        CreateMap<Author, AuthorCreateDTO>().ReverseMap();

        CreateMap<Book, BookDTO>()
            .ForMember(x => x.GenreName, opt => opt.MapFrom(src => src.Genre.Name))
            .ForMember(x => x.AuthorFullName, opt => opt.MapFrom(src => (src.Author.Name + " "+src.Author.SurName))).ReverseMap();
        CreateMap<Book, BookCreateDTO>().ReverseMap();
        CreateMap<Book, BookUpdateDTO>().ReverseMap();

        CreateMap<Customer, CustomerDTO>().ReverseMap();
        CreateMap<Customer, CustomerCreateDTO>().ReverseMap();
        CreateMap<Customer, CustomerUpdateDTO>().ReverseMap();

        CreateMap<Genre, GenreDTO>().ReverseMap();
        CreateMap<Genre, GenreCreateDTO>().ReverseMap();
        CreateMap<Genre, GenreUpdateDTO>().ReverseMap();

        CreateMap<OrderDetails, OrderDetailsCreateDTO>().ReverseMap();
        CreateMap<OrderDetailsDTO, OrderDetails>()
            .ForPath(x => x.Book.Name, opt => opt.MapFrom(src => (src.BookName)))
            //.ForMember(x => x.BookId, opt => opt.MapFrom(src => (src.Book.Id)))
            .ReverseMap();
        CreateMap<Order, OrderDTO>().ReverseMap();
        CreateMap<Order, OrderCreateDTO>().ReverseMap();
      

    }
}
