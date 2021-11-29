using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AtacadoAPI.Data;
using AtacadoAPI.Model;
using Microsoft.AspNetCore.Mvc;
using AtacadoAPI.Data.Dtos.Venda;

namespace AtacadoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private ClienteContext _contextVenda;
        private IMapper _mapperVenda;

        public VendaController(ClienteContext context, IMapper mapper)
        {
            _contextVenda = context;
            _mapperVenda = mapper;
        }
        [HttpPost]
        public IActionResult AddVenda([FromBody] CreateVendaDto vendaDto)
        {
            Venda venda = _mapperVenda.Map<Venda>(vendaDto);
            _contextVenda.Vendas.Add(venda);
            _contextVenda.SaveChanges();
            return CreatedAtAction(nameof(GetVendaById), new { Id = venda.Id }, venda);
        }

        [HttpGet]
        public IEnumerable<Venda> GetVendas()
        {
            return _contextVenda.Vendas;
        }

        [HttpGet("{id}")]
        public IActionResult GetVendaById(int id)
        {
            Venda venda = _contextVenda.Vendas.FirstOrDefault(venda => venda.Id == id);
            if (venda != null)
            {
                ReadVendaDto vendaDto = _mapperVenda.Map<ReadVendaDto>(venda);
                return Ok(vendaDto);
            }
            return NotFound();
        }

    }
}
