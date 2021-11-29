using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AtacadoAPI.Data.Dtos.Produto;
using AtacadoAPI.Model;


namespace AtacadoAPI.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile() 
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<UpdateProdutoDto, Produto>();
        }
    }
}
