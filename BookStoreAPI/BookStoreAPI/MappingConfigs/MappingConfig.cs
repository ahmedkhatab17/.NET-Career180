using AutoMapper;
using BookStoreAPI.DTOs.BooksDTOs;
using BookStoreAPI.DTOs.CustomerDTOs;
using BookStoreAPI.DTOs.OrdersDTOs;
using BookStoreAPI.Models;

namespace BookStoreAPI.MappingConfigs
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Customer,AddCustomerDTO>().ReverseMap();
            CreateMap<Customer,EditCustomerDTO>().ReverseMap();
            CreateMap<Customer,SelectCustomerDTO>().ReverseMap();
            CreateMap<Admin, AddCustomerDTO>().ReverseMap();
            CreateMap<Book, AddBookDTO>().ReverseMap();
            CreateMap<Order, AddOrderDTO>().ReverseMap();
            CreateMap<OrderItems,OrderItemDTO>().ReverseMap();

            CreateMap<Order,DisplayOrderDTO>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));

            CreateMap<OrderItems, DisplayOrderItemsDTO>()
            .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.Title));

            CreateMap<Book, DisplayBookDTO>()
                .ForMember(dest => dest.Catalog, opt => opt.MapFrom(src => src.Catalog.Name))
                .ForMember(dest => dest.Authorname, opt => opt.MapFrom(src => src.Author.FulName));
        }
    }
}
