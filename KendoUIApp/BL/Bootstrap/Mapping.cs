using AutoMapper;
using BL.DTO;
using DAL.Entities;

namespace BL.Bootstrap
{
    public static class Mapping
    {
        public static void ConfigureMapping()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Customer, CustomerDTO>().ReverseMap();

                config.CreateMap<Address, AddressDTO>().ReverseMap();
            });
        }
    }
}
