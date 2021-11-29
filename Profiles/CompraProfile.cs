using AtacadoAPI.Data.Dtos.Compra;
using AtacadoAPI.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtacadoAPI.Profiles
{
    public class CompraProfile : Profile
    {
        public CompraProfile()
        {
            CreateMap<CreateCompraDto, Compra>();
            CreateMap<Compra, ReadCompraDto>();
        }
    }
}
