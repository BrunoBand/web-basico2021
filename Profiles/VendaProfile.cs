using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AtacadoAPI.Data.Dtos.Venda;
using AtacadoAPI.Model;

namespace AtacadoAPI.Profiles
{
    public class VendaProfile : Profile
    {
        public VendaProfile()
        {
            CreateMap<CreateVendaDto, Venda>();
            CreateMap<Venda, ReadVendaDto>();
        }
    }
}
