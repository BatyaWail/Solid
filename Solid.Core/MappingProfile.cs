
using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Station, StationDto>().ReverseMap();
            // CreateMap<Station, StationDto>()
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
            //.ForMember(dest => dest.CountFamily, opt => opt.MapFrom(src => src.CountFamily))
            //.ForMember(dest => dest.Day, opt => opt.MapFrom(src => src.Day));
        }
    }
}
