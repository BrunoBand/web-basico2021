using AtacadoAPI.Data.Dtos.Fornecedor;
using AtacadoAPI.Model;
using AutoMapper;
using System;

namespace AtacadoAPI.Profiles
{
    public class FornecedorProfile : Profile
    {
        public FornecedorProfile()
        {
            CreateMap<CreateFornecedorDto, Fornecedor>();
            CreateMap<Fornecedor, ReadFornecedorDto>();
            CreateMap<UpdateFornecedorDto, Fornecedor>();
        }
    }
}
